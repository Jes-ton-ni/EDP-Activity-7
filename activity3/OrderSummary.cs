using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeOpenXml;
using System.IO;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Style;
using OfficeOpenXml.Drawing.Chart.Style;
using OfficeOpenXml.Drawing.Chart;


namespace activity3
{
    public partial class OrderSummary : Form
    {
        public OrderSummary()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            DisplayOrdersTransaction();
        }

        private void DisplayOrdersTransaction()
        {
            try
            {
                // Create a connection
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Open the connection
                    connection.Open();

                    // Define the SQL query with joins to get customer and product names
                    string query = @"
                            SELECT 
                                o.OrderID, 
                                u.name AS Customer, 
                                p.ProductName AS Product, 
                                o.Price, 
                                o.Quantity, 
                                o.OrderDate, 
                                o.TotalAmount, 
                                o.Status 
                            FROM 
                                orders o
                            INNER JOIN 
                                user u ON o.CustomerID = u.user_id
                            INNER JOIN 
                                products p ON o.ProductID = p.ProductID
                            ORDER BY 
                                o.OrderID
                            ";

                    // Create a MySqlCommand object with the query and connection
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Create a DataTable to hold the results
                        DataTable dataTable = new DataTable();

                        // Use a MySqlDataAdapter to fill the DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Bind the DataTable to the DataGridView
                        transactionGridView.DataSource = dataTable;

                        // Add a button column to the DataGridView
                        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                        buttonColumn.HeaderText = "Print Receipt";
                        buttonColumn.Name = "PrintReceipt";
                        buttonColumn.Text = "Print";
                        buttonColumn.UseColumnTextForButtonValue = true;
                        transactionGridView.Columns.Add(buttonColumn);

                        transactionGridView.CellContentClick += (sender, e) => transactionGridView_CellContentClick(sender, e, dataTable);

                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Event handler for button click to print the receipt
        private void transactionGridView_CellContentClick(object sender, DataGridViewCellEventArgs e, DataTable dataTable)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == transactionGridView.Columns["PrintReceipt"].Index)
            {
                // Get the OrderID of the selected row
                int orderID = Convert.ToInt32(transactionGridView.Rows[e.RowIndex].Cells["OrderID"].Value);

                // Generate and print the receipt for the selected OrderID
                GenerateReceipt(orderID, dataTable);
            }
        }

        // Method to generate and print the receipt based on the OrderID
        private void GenerateReceipt(int orderID, DataTable dataTable)
        {
            try
            {
                // Set the LicenseContext to NonCommercial or Commercial based on your use case
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Load the existing Excel template
                string templateFilePath = @"ReceiptTemplate.xlsx"; // Update the path to your template
                FileInfo templateFile = new FileInfo(templateFilePath);

                // Check if the template file exists
                if (!templateFile.Exists)
                {
                    MessageBox.Show("Template file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Find the row in the DataTable with the specified OrderID
                DataRow[] orderRows = dataTable.Select($"OrderID = {orderID}");

                // Check if the order exists
                if (orderRows.Length > 0)
                {
                    DataRow orderRow = orderRows[0]; // Assuming there's only one order with the specified ID

                    // Create a new Excel package based on the template
                    using (ExcelPackage excelPackage = new ExcelPackage(templateFile))
                    {
                        // Add a worksheet to the Excel package
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets["Receipt"];

                        // Add order details to the Excel worksheet
                        worksheet.Cells["C3"].Value = orderRow["OrderID"];
                        worksheet.Cells["C7"].Value = orderRow["Customer"];
                        worksheet.Cells["B12"].Value = orderRow["Product"];
                        worksheet.Cells["E12"].Value = orderRow["Price"];
                        worksheet.Cells["D12"].Value = orderRow["Quantity"];
                        worksheet.Cells["C4"].Value = orderRow["OrderDate"]; //for date
                        worksheet.Cells["C5"].Value = orderRow["OrderDate"]; //for time
                        worksheet.Cells["F12"].Value = orderRow["TotalAmount"];
                        worksheet.Cells["C15"].Value = orderRow["Status"];

                        // Apply date and time formats to the cells
                        worksheet.Cells["C4"].Style.Numberformat.Format = "MM/dd/yyyy"; // Date format
                        worksheet.Cells["C5"].Style.Numberformat.Format = "hh:mm:ss"; // Time format

                        // Apply Philippine accounting format to the cell
                        worksheet.Cells["E12"].Style.Numberformat.Format = "₱#,##0.00;[Red](₱#,##0.00)";
                        // Apply Philippine accounting format to the cell
                        worksheet.Cells["F12"].Style.Numberformat.Format = "₱#,##0.00;[Red](₱#,##0.00)";

                        // Protect worksheet with password
                        worksheet.Protection.IsProtected = true;
                        worksheet.Protection.SetPassword("TryToBeatMe");

                        // Protect workbook structure with password
                        excelPackage.Workbook.Protection.LockStructure = true;
                        excelPackage.Workbook.Protection.SetPassword("TryToBeatMe");

                        // Save the Excel package to a file in the Downloads folder
                        string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", $"Receipt_Order_{orderID}.xlsx");
                        excelPackage.SaveAs(new FileInfo(savePath));

                        // Display a success message
                        MessageBox.Show($"Receipt generated successfully. Saved at: {savePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Order with ID {orderID} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProcessingOrders()
        {
            try
            {
                // Create a connection
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Open the connection
                    connection.Open();

                    // Define the SQL query with joins to get customer and product names
                    string query = @"
                                    SELECT 
                                        o.OrderID, 
                                        u.name AS Customer, 
                                        p.ProductName AS Product, 
                                        o.Price, 
                                        o.Quantity, 
                                        o.OrderDate, 
                                        o.TotalAmount, 
                                        o.Status 
                                    FROM 
                                        orders o
                                    INNER JOIN 
                                        user u ON o.CustomerID = u.user_id
                                    INNER JOIN 
                                        products p ON o.ProductID = p.ProductID
                                    WHERE 
                                            o.Status = 'Processing'
                                    ORDER BY 
                                            o.OrderID
                                ";

                    // Create a MySqlCommand object with the query and connection
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Create a DataTable to hold the results
                        DataTable dataTable = new DataTable();

                        // Use a MySqlDataAdapter to fill the DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Bind the DataTable to the DataGridView
                        transactionGridView.DataSource = dataTable;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CompletedOrders()
        {
            try
            {
                // Create a connection
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Open the connection
                    connection.Open();

                    // Define the SQL query with joins to get customer and product names
                    string query = @"
                                    SELECT 
                                        o.OrderID, 
                                        u.name AS Customer, 
                                        p.ProductName AS Product, 
                                        o.Price, 
                                        o.Quantity, 
                                        o.OrderDate, 
                                        o.TotalAmount, 
                                        o.Status 
                                    FROM 
                                        orders o
                                    INNER JOIN 
                                        user u ON o.CustomerID = u.user_id
                                    INNER JOIN 
                                        products p ON o.ProductID = p.ProductID
                                    WHERE 
                                            o.Status = 'Completed'
                                    ORDER BY 
                                            o.OrderID
                                ";

                    // Create a MySqlCommand object with the query and connection
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Create a DataTable to hold the results
                        DataTable dataTable = new DataTable();

                        // Use a MySqlDataAdapter to fill the DataTable
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        // Bind the DataTable to the DataGridView
                        transactionGridView.DataSource = dataTable;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void GenerateTransactionExcel(DataTable transactionData)
        {
            try
            {
                // Set the LicenseContext to NonCommercial or Commercial based on your use case
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Load the existing Excel template
                string templateFilePath = @"TransactionTemplate.xlsx"; // Update the path to your template
                FileInfo templateFile = new FileInfo(templateFilePath);

                using (ExcelPackage excelPackage = new ExcelPackage(templateFile))
                {
                    // Get the worksheet from the template
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets["Transactions"];
                    ExcelWorksheet graphWorksheet = excelPackage.Workbook.Worksheets["Graph"];

                    // Check if the worksheet exists

                    // Check if the worksheet exists
                    if (worksheet != null)
                    {
                        // Get the starting row for data insertion
                        int startRow = 6;
                        int startColumn = 2;

                        // Define and apply cell style if it doesn't already exist
                        if (!excelPackage.Workbook.Styles.NamedStyles.Any(s => s.Name == "TransactionData"))
                        {
                            var cellStyle = excelPackage.Workbook.Styles.CreateNamedStyle("TransactionData");
                            cellStyle.Style.WrapText = true;
                            cellStyle.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            cellStyle.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        }

                        // Fill in transaction data from the DataTable
                        for (int i = 0; i < transactionData.Rows.Count; i++)
                        {
                            // Populate each column with corresponding data from the DataTable
                            for (int j = 0; j < transactionData.Columns.Count; j++)
                            {
                                worksheet.Cells[startRow + i, j + startColumn].Value = transactionData.Rows[i][j];
                                worksheet.Cells[startRow + i, j + startColumn].StyleName = "TransactionData"; // Apply the cell style
                            }
                        }

                        // Apply Accounting format to the Order Date
                        int priceColumnIndex = 4;
                        using (var range = worksheet.Cells[startRow, startColumn + priceColumnIndex - 1, worksheet.Dimension.End.Row, startColumn + priceColumnIndex - 1])
                        {
                            range.Style.Numberformat.Format = "₱#,##0.00;[Red](₱#,##0.00)";
                        }

                        // Apply Date format to the Order Date
                        int orderDateColumnIndex = 6;
                        using (var range = worksheet.Cells[startRow, startColumn + orderDateColumnIndex - 1, worksheet.Dimension.End.Row, startColumn + orderDateColumnIndex - 1])
                        {
                            range.Style.Numberformat.Format = "MM/dd/yyyy"; // You can adjust the format as needed
                        }

                        // Apply Accounting format to the Total Ammount
                        priceColumnIndex = 7;
                        using (var range = worksheet.Cells[startRow, startColumn + priceColumnIndex - 1, worksheet.Dimension.End.Row, startColumn + priceColumnIndex - 1])
                        {
                            range.Style.Numberformat.Format = "₱#,##0.00;[Red](₱#,##0.00)";
                        }

                        string hexColor = "#2F75B5";

                        // Convert the hex color string to a Color object
                        Color color = ColorTranslator.FromHtml(hexColor);

                        // Define and apply cell style
                        var footerStyle = excelPackage.Workbook.Styles.CreateNamedStyle("OrderTransactionFooter");
                        footerStyle.Style.WrapText = true;
                        footerStyle.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        footerStyle.Style.Fill.BackgroundColor.SetColor(color);
                        footerStyle.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        footerStyle.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;


                        // Insert the total stocks into the Excel file after the last row of the table
                        int lastRow = startRow + transactionData.Rows.Count;
                        for (int j = 0; j < transactionData.Columns.Count; j++)
                        {
                            worksheet.Cells[lastRow, startColumn++].StyleName = "OrderTransactionFooter";
                        }

                        // Calculate counts of completed and processing orders
                        int completedCount = transactionData.AsEnumerable().Count(row => row["Status"].ToString().Equals("Completed"));
                        int processingCount = transactionData.AsEnumerable().Count(row => row["Status"].ToString().Equals("Processing"));

                        // Add data to the cells on the "Graph" sheet
                        graphWorksheet.Cells["B6"].Value = "Status";
                        graphWorksheet.Cells["C6"].Value = "Count";
                        graphWorksheet.Cells["B7"].Value = "Completed";
                        graphWorksheet.Cells["C7"].Value = completedCount;
                        graphWorksheet.Cells["B8"].Value = "Processing";
                        graphWorksheet.Cells["C8"].Value = processingCount;

                        // Add the pie chart to the "Graph" sheet
                        ExcelChart chart = graphWorksheet.Drawings.AddChart("TransactionPieChart", eChartType.PieExploded3D);
                        chart.SetPosition(5, 0, 3, 0);
                        chart.SetSize(600, 400);
                        var series = (ExcelPieChartSerie)chart.Series.Add(graphWorksheet.Cells["C7:C8"], graphWorksheet.Cells["B7:B8"]);
                        series.Header = "Status";

                        // Set the chart title
                        chart.Title.Text = "Order Status";

                        // Protect worksheet with password
                        worksheet.Protection.IsProtected = true;
                        worksheet.Protection.SetPassword("TryToBeatMe");
                        graphWorksheet.Protection.IsProtected = true;
                        graphWorksheet.Protection.SetPassword("TryToBeatMe");

                        // Protect workbook structure with password
                        excelPackage.Workbook.Protection.LockStructure = true;
                        excelPackage.Workbook.Protection.SetPassword("TryToBeatMe");

                        // Set the file save path to the Downloads folder
                        string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
                        string savePath = Path.Combine(downloadsFolderPath, "Transactions.xlsx");

                        // Save the modified Excel package to the specified file
                        excelPackage.SaveAs(new FileInfo(savePath));

                        MessageBox.Show("Excel file generated successfully. Saved at: " + savePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Worksheet 'Transactions' not found in the template file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void all_Click(object sender, EventArgs e)
        {
            DisplayOrdersTransaction();
        }

        private void completed_Click(object sender, EventArgs e)
        {
            CompletedOrders();
        }

        private void processing_Click(object sender, EventArgs e)
        {
            ProcessingOrders();
        }

        private void printTransactionHistory_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the inventory data from the DataGridView
                DataTable transactionData = (DataTable)transactionGridView.DataSource;

                // Generate the Excel file
                GenerateTransactionExcel(transactionData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_Inventory().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Get MySqlConnection object using the connection string from dbConnection class
                using (MySqlConnection conn = dbConnection.GetConnection())
                {
                    // Open the connection
                    conn.Open();

                    // Set the status to 0 for the logged-in user
                    string updateSql = "UPDATE user SET status = 0 WHERE username = @username";
                    MySqlCommand updateCmd = new MySqlCommand(updateSql, conn);
                    updateCmd.Parameters.AddWithValue("@username", UserInfo.Username);
                    updateCmd.ExecuteNonQuery();

                    // Navigate to the login form
                    var login = new login();
                    this.Hide();
                    login.Show();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating user status: " + ex.Message);
            }
        }
    }


}

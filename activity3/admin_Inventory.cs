using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using OfficeOpenXml.Table;
using OfficeOpenXml.Drawing.Chart;


namespace activity3
{
    public partial class admin_Inventory : Form
    {
        public admin_Inventory()
        {
            InitializeComponent();
        }

        private void admin_Inventory_Load(object sender, EventArgs e)
        {
            DisplayInventory();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderSummary().Show();
        }

        private void DisplayInventory()
        {
            try
            {
                // Create a connection
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Open the connection
                    connection.Open();

                    // Define the SQL query with the join to get product names
                    string query = @"
                SELECT 
                    i.InventoryID, 
                    i.ProductID,
                    p.ProductName,
                    p.Category,
                    p.Description,
                    i.StockQuantity,
                    p.Price
                FROM 
                    inventory i
                INNER JOIN 
                    products p ON i.ProductID = p.ProductID
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
                        inventoryGridView.DataSource = dataTable;

                        // Hide the ProductID column
                        inventoryGridView.Columns["ProductID"].Visible = false;
                        inventoryGridView.Columns["Description"].Visible = false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayAvailableInventory()
        {
            try
            {
                // Create a connection
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Open the connection
                    connection.Open();

                    // Define the SQL query with the join to get product names
                    string query = @"
                SELECT 
                    i.InventoryID, 
                    i.ProductID,
                    p.ProductName,
                    p.Category,
                    p.Description,
                    i.StockQuantity,
                    p.Price
                FROM 
                    inventory i
                INNER JOIN 
                    products p ON i.ProductID = p.ProductID
                WHERE 
                    i.StockQuantity > 0;
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
                        inventoryGridView.DataSource = dataTable;

                        // Hide the ProductID column
                        inventoryGridView.Columns["ProductID"].Visible = false;
                        inventoryGridView.Columns["Description"].Visible = false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayOutOfStockInventory()
        {
            try
            {
                // Create a connection
                using (MySqlConnection connection = dbConnection.GetConnection())
                {
                    // Open the connection
                    connection.Open();

                    // Define the SQL query with the join to get product names
                    string query = @"
                SELECT 
                    i.InventoryID, 
                    i.ProductID,
                    p.ProductName,
                    p.Category,
                    p.Description,
                    i.StockQuantity,
                    p.Price
                FROM 
                    inventory i
                INNER JOIN 
                    products p ON i.ProductID = p.ProductID
                WHERE 
                    i.StockQuantity <= 0;
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
                        inventoryGridView.DataSource = dataTable;

                        // Hide the ProductID column
                        inventoryGridView.Columns["ProductID"].Visible = false;
                        inventoryGridView.Columns["Description"].Visible = false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void all_Click(object sender, EventArgs e)
        {
            DisplayInventory();
        }

        private void Available_Click(object sender, EventArgs e)
        {
            DisplayAvailableInventory();
        }

        private void outOfStock_Click(object sender, EventArgs e)
        {
            DisplayOutOfStockInventory();
        }

        private void GenerateInventoryExcel(DataTable inventoryData)
        {
            try
            {
                // Set the LicenseContext to NonCommercial or Commercial based on your use case
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Load the existing Excel template
                string templateFilePath = @"InventoryTemplate.xlsx"; // Update the path to your template
                FileInfo templateFile = new FileInfo(templateFilePath);

                using (ExcelPackage excelPackage = new ExcelPackage(templateFile))
                {
                    // Get the worksheet from the template
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets["Inventory"];

                    // Check if the worksheet exists
                    if (worksheet != null)
                    {
                        // Get the starting row for data insertion
                        int startRow = 3; 
                        int startColumn = 2;

                        // Define and apply cell style
                        var cellStyle = excelPackage.Workbook.Styles.CreateNamedStyle("InventoryData");
                        cellStyle.Style.WrapText = true;
                        cellStyle.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        cellStyle.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                        // Fill in inventory data from the DataTable
                        for (int i = 0; i < inventoryData.Rows.Count; i++)
                        {
                            // Populate each column with corresponding data from the DataTable
                            for (int j = 0; j < inventoryData.Columns.Count; j++)
                            {
                                worksheet.Cells[startRow + i, j + startColumn].Value = inventoryData.Rows[i][j];
                                worksheet.Cells[startRow + i, j + startColumn].StyleName = "InventoryData"; // Apply the cell style
                            }
                        }

                        // Apply accounting format to the Price column
                        int priceColumnIndex = 7; 
                        using (var range = worksheet.Cells[startRow, startColumn + priceColumnIndex - 1, worksheet.Dimension.End.Row, startColumn + priceColumnIndex - 1])
                        {
                            range.Style.Numberformat.Format = "₱#,##0.00;[Red](₱#,##0.00)";
                        }


                        string hexColor = "#2F75B5";

                        // Convert the hex color string to a Color object
                        Color color = ColorTranslator.FromHtml(hexColor);

                        // Define and apply cell style
                        var footerStyle = excelPackage.Workbook.Styles.CreateNamedStyle("InventoryFooter");
                        footerStyle.Style.WrapText = true;
                        footerStyle.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        footerStyle.Style.Fill.BackgroundColor.SetColor(color);
                        footerStyle.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        footerStyle.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;


                        // Insert the total stocks into the Excel file after the last row of the table
                        int lastRow = startRow + inventoryData.Rows.Count;
                        for (int j = 0; j < inventoryData.Columns.Count; j++)
                        {
                            worksheet.Cells[lastRow, startColumn++].StyleName = "InventoryFooter";
                        }

                        //  Get the worksheet from the template
                        ExcelWorksheet graphWorksheet = excelPackage.Workbook.Worksheets["Graph"];

                        // Add headers for product name and available stocks
                        graphWorksheet.Cells["B4"].Value = "Product Name";
                        graphWorksheet.Cells["C4"].Value = "Available Stocks";

                        // Fill data for product name and available stocks
                        for (int i = 0; i < inventoryData.Rows.Count; i++)
                        {
                            graphWorksheet.Cells["B" + (i + 5)].Value = inventoryData.Rows[i]["ProductName"];
                            graphWorksheet.Cells["C" + (i + 5)].Value = inventoryData.Rows[i]["StockQuantity"];
                        }

                        // Add pie chart
                        var pieChart = graphWorksheet.Drawings.AddChart("PieChart", eChartType.PieExploded3D);
                        pieChart.SetPosition(3, 0, 4, 0);
                        pieChart.SetSize(600, 400);

                        // Set the chart title
                        pieChart.Title.Text = "Product Stocks Distribution";

                        // Protect the drawing (chart) to prevent its position from being changed
                        pieChart.Locked = true;

                        // Define the data range for product names and available stocks
                        var productNameRange = graphWorksheet.Cells["B5:B" + (inventoryData.Rows.Count + 4)];
                        var stockQuantityRange = graphWorksheet.Cells["C5:C" + (inventoryData.Rows.Count + 4)];

                        // Add the chart series using the defined data ranges
                        var series = pieChart.Series.Add(stockQuantityRange, productNameRange);

                        // Protect worksheet with password
                        worksheet.Protection.IsProtected = true;
                        worksheet.Protection.SetPassword("TryToBeatMe");
                        graphWorksheet.Protection.IsProtected = true;
                        graphWorksheet.Protection.SetPassword("TryToBeatMe");

                        // Protect workbook structure with password
                        excelPackage.Workbook.Protection.LockStructure = true;
                        excelPackage.Workbook.Protection.SetPassword("TryToBeatMe");

                        // Save the modified Excel package to a new file
                        string downloadsFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
                        string filePath = Path.Combine(downloadsFolderPath, "Inventory.xlsx");
                        FileInfo excelFile = new FileInfo(filePath);
                        excelPackage.SaveAs(excelFile);

                        MessageBox.Show("Excel file generated successfully. Saved at: " + excelFile.FullName);
                    }
                    else
                    {
                        MessageBox.Show("Worksheet 'Inventory' not found in the template file.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void printInventory_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the inventory data from the DataGridView
                DataTable inventoryData = (DataTable)inventoryGridView.DataSource;

                // Generate the Excel file
                GenerateInventoryExcel(inventoryData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }


}

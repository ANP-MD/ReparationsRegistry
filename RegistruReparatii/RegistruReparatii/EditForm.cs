using MySql.Data.MySqlClient;
using System.Data;

namespace RegistruReparatii
{
    public partial class EditForm : Form
    {
        private static readonly string client_version = "1.0.0";
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        private DataGridViewComboBoxColumn institutionColumn;
        private DataGridViewComboBoxColumn categoryColumn;
        private DataGridViewComboBoxColumn receiptPersonColumn;
        private DataGridView dataGridView;
        private DataGridView statistics;
        private int pageNumber = 1;
        private int months = 1;

        public EditForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeDataGridView();
            LoadComboDropdown();
            pageButton.Text = pageNumber.ToString();
            statisticsPageBtn.Text = months.ToString();
            LoadData();
        }

        // Initialization Methods
        private void InitializeDatabaseConnection()
        {
            string connectionString = $"Server={Queries.ip};Database={Queries.database};User ID={Queries.username};Password={Queries.password};";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        private void InitializeDataGridView()
        {
            dataGridView = new DataGridView
            {
                AutoGenerateColumns = false,
                AllowUserToAddRows = true,
                AllowUserToDeleteRows = true,
                Dock = DockStyle.Fill,
                BackgroundColor = Color.FromArgb(24, 30, 54),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    ForeColor = Color.Gainsboro,
                    Font = new Font("SegoeUI", 10),
                    BackColor = Color.FromArgb(24, 30, 54)
                }
            };

            // Adding columns
            AddColumnsToDataGridView();

            // Add DataGridView to the panel
            editPanel.Controls.Add(dataGridView);
            dataGridView.UserDeletingRow += dataGridView_UserDeletingRow;
        }

        private void AddColumnsToDataGridView()
        {
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "RepairID", DataPropertyName = "RepairID", Visible = false });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Inserted Date", DataPropertyName = "InsertedData" });

            categoryColumn = new DataGridViewComboBoxColumn { HeaderText = "Category", DataPropertyName = "CategoryID", DisplayMember = "CategoryName", ValueMember = "CategoryID" };
            dataGridView.Columns.Add(categoryColumn);

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Serial Number", DataPropertyName = "SerialNumber" });

            institutionColumn = new DataGridViewComboBoxColumn { HeaderText = "Institution", DataPropertyName = "Institution", DisplayMember = "InstitutionName", ValueMember = "InstitutionID" };
            dataGridView.Columns.Add(institutionColumn);

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Courier Name", DataPropertyName = "CourierName" });

            receiptPersonColumn = new DataGridViewComboBoxColumn { HeaderText = "ANP Receipt Person", DataPropertyName = "ANP_Receipt_Person", DisplayMember = "name", ValueMember = "employeeID" };
            dataGridView.Columns.Add(receiptPersonColumn);

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Repair Date", DataPropertyName = "RepairDate" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Repair Successful", DataPropertyName = "RepairSuccessful" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Receiving Person", DataPropertyName = "ReceivingPerson" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Receiving Date", DataPropertyName = "ReceivingDate" });

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        // Data Loading Methods
        private void LoadData()
        {
            try
            {
                int pageSize = 10;
                int offset = (pageNumber - 1) * pageSize;
                string query = BuildDataQuery(offset, pageSize);

                adapter = new MySqlDataAdapter(query, connection);
                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                LoadDropdowns();
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private string BuildDataQuery(int offset, int pageSize)
        {
            string selectedInstitution = institutionComboBox.SelectedValue.ToString();
            return selectedInstitution == "99"
                ? $"SELECT * FROM date LIMIT {offset}, {pageSize}"
                : $"SELECT * FROM date WHERE Institution = '{selectedInstitution}' LIMIT {offset}, {pageSize}";
        }

        private void LoadDropdowns()
        {
            LoadInstitutionDropdown();
            LoadCategoryDropdown();
            LoadEmployeeDropdown();
        }

        private void LoadEmployeeDropdown()
        {
            LoadDropdownData("SELECT employeeID, name FROM employees", receiptPersonColumn);
        }

        private void LoadInstitutionDropdown()
        {
            LoadDropdownData("SELECT InstitutionID, InstitutionName FROM institutions", institutionColumn);
        }

        private void LoadCategoryDropdown()
        {
            LoadDropdownData("SELECT CategoryID, CategoryName FROM category", categoryColumn);
        }

        private void LoadDropdownData(string query, DataGridViewComboBoxColumn comboBoxColumn)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxColumn.DataSource = table;
        }

        private void LoadComboDropdown()
        {
            DataTable institutionTable = LoadTable("SELECT InstitutionID, InstitutionName FROM institutions");
            DataRow allRow = institutionTable.NewRow();
            allRow["InstitutionID"] = 99;
            allRow["InstitutionName"] = "All";
            institutionTable.Rows.InsertAt(allRow, 0);

            institutionComboBox.DataSource = institutionTable;
            institutionComboBox.DisplayMember = "InstitutionName";
            institutionComboBox.ValueMember = "InstitutionID";
            institutionComboBox.SelectedIndex = 0;
        }

        private DataTable LoadTable(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Row Operations
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row.RowState == DataRowState.Added) InsertRow(row);
                    else if (row.RowState == DataRowState.Modified) UpdateRow(row);
                }

                adapter.Update(dataTable);
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void InsertRow(DataRow row)
        {
            string query = @"
                INSERT INTO date (InsertedData, SerialNumber, CourierName, ANP_Receipt_Person, RepairDate, RepairSuccessful, CategoryID, Institution, ReceivingPerson, ReceivingDate)
                VALUES (@InsertedData, @SerialNumber, @CourierName, @ANP_Receipt_Person, @RepairDate, @RepairSuccessful, @CategoryID, @Institution, @ReceivingPerson, @ReceivingDate)";

            ExecuteRowCommand(query, row);
            row.AcceptChanges();
        }

        private void UpdateRow(DataRow row)
        {
            string query = @"
                UPDATE date SET 
                    InsertedData = @InsertedData, SerialNumber = @SerialNumber, CourierName = @CourierName, ANP_Receipt_Person = @ANP_Receipt_Person,
                    RepairDate = @RepairDate, RepairSuccessful = @RepairSuccessful, CategoryID = @CategoryID, Institution = @Institution,
                    ReceivingPerson = @ReceivingPerson, ReceivingDate = @ReceivingDate
                WHERE RepairID = @RepairID";

            ExecuteRowCommand(query, row);
            row.AcceptChanges();
        }

        private void forwardStatisticsBtn_Click(object sender, EventArgs e)
        {
            months++;
            dataGridView.Dispose();
            statisticsPageBtn.Text = months.ToString();

            editPanel.Controls.Clear();
            editPanel.Controls.Remove(dataGridView);

            LoadRepairsByInstitution();
        }

        private void backStatisticsBtn_Click(object sender, EventArgs e)
        {
            if (months > 1)
            {
                months--;
                statisticsPageBtn.Text = months.ToString();

                dataGridView.Dispose();

                editPanel.Controls.Clear();
                editPanel.Controls.Remove(dataGridView);

                LoadRepairsByInstitution();
            }

        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            dataGridView.Dispose();

            editPanel.Controls.Clear();
            editPanel.Controls.Remove(dataGridView);

            LoadRepairsByInstitution();
        }

        private void LoadRepairsByInstitution()
        {

            try
            {
                // Query to count repairs by institution where RepairDate is not null and within the past X months
                string query = @"
            SELECT 
                i.InstitutionName, 
                COUNT(d.RepairID) AS RepairCount 
            FROM 
                reparatii.institutions i 
            LEFT JOIN 
                reparatii.date d ON i.InstitutionID = d.Institution 
            WHERE 
                d.RepairDate IS NOT NULL AND 
                d.RepairDate >= DATE_SUB(CURDATE(), INTERVAL @months MONTH) 
            GROUP BY 
                i.InstitutionName 
            ORDER BY 
                i.InstitutionName";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@months", months); // Use parameter to prevent SQL injection

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable resultsTable = new DataTable();
                adapter.Fill(resultsTable);

                // Create a new DataTable to display the results
                DataTable displayTable = new DataTable();
                displayTable.Columns.Add("Institution", typeof(string));
                displayTable.Columns.Add("Repair Count", typeof(int));



                // Populate the display table with results
                foreach (DataRow row in resultsTable.Rows)
                {
                    displayTable.Rows.Add(row["InstitutionName"], row["RepairCount"]);
                }

                // Calculate total repairs
                int totalRepairs = displayTable.AsEnumerable().Sum(r => r.Field<int>("Repair Count"));
                displayTable.Rows.Add("Total:", totalRepairs); // Add total row

                // Create a new DataGridView for displaying the results
                statistics = new DataGridView
                {
                    DataSource = displayTable,
                    ReadOnly = true,
                    Dock = DockStyle.Fill,
                    BackgroundColor = Color.FromArgb(24, 30, 54),
                };

                statistics.DefaultCellStyle.ForeColor = Color.Gainsboro;
                statistics.DefaultCellStyle.Font = new Font("SegoeUI", 10);
                statistics.DefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);

                // Clear any existing controls and add results DataGridView to the form or panel
                editPanel.Controls.Clear(); // Clear previous controls if necessary
                editPanel.Controls.Add(statistics); // Assuming editPanel exists in your form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading repairs: " + ex.Message);
            }
        }


        private void explorerBtn_Click(object sender, EventArgs e)
        {

            statistics.Dispose();

            editPanel.Controls.Clear();
            editPanel.Controls.Remove(statistics);

            InitializeDataGridView();
            LoadData();
        }

        private void ExecuteRowCommand(string query, DataRow row)
        {
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                SetCommandParameters(command, row);
                command.ExecuteNonQuery();
            }
        }

        private void SetCommandParameters(MySqlCommand command, DataRow row)
        {
            command.Parameters.AddWithValue("@InsertedData", row["InsertedData"] is DBNull ? (object)DBNull.Value : Convert.ToDateTime(row["InsertedData"]));
            command.Parameters.AddWithValue("@SerialNumber", row["SerialNumber"]?.ToString());
            command.Parameters.AddWithValue("@CourierName", row["CourierName"]?.ToString());
            command.Parameters.AddWithValue("@ANP_Receipt_Person", row["ANP_Receipt_Person"] is DBNull ? (object)DBNull.Value : Convert.ToInt32(row["ANP_Receipt_Person"]));
            command.Parameters.AddWithValue("@RepairDate", row["RepairDate"] is DBNull ? (object)DBNull.Value : Convert.ToDateTime(row["RepairDate"]));
            command.Parameters.AddWithValue("@RepairSuccessful", row["RepairSuccessful"] is DBNull ? (object)DBNull.Value : Convert.ToBoolean(row["RepairSuccessful"]));
            command.Parameters.AddWithValue("@CategoryID", row["CategoryID"] is DBNull ? (object)DBNull.Value : Convert.ToInt32(row["CategoryID"]));
            command.Parameters.AddWithValue("@Institution", row["Institution"] is DBNull ? (object)DBNull.Value : Convert.ToInt32(row["Institution"]));
            command.Parameters.AddWithValue("@ReceivingPerson", row["ReceivingPerson"]?.ToString());
            command.Parameters.AddWithValue("@ReceivingDate", row["ReceivingDate"] is DBNull ? (object)DBNull.Value : Convert.ToDateTime(row["ReceivingDate"]));
            command.Parameters.AddWithValue("@RepairID", row["RepairID"]);
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["RepairID"].Value != null)
            {
                string repairID = e.Row.Cells["RepairID"].Value.ToString();
                string query = "DELETE FROM date WHERE RepairID = @RepairID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@RepairID", repairID);
                command.ExecuteNonQuery();
            }
        }

        // Pagination & Filtering
        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            pageNumber++;
            pageButton.Text = pageNumber.ToString();
            LoadData();
        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                pageButton.Text = pageNumber.ToString();
                LoadData();
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadData(); // Reload data from the database
            MessageBox.Show("Data refreshed successfully!");
        }

        private void institutionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

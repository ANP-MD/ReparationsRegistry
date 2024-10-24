namespace RegistruReparatii
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm; // Changed to MainForm type

        public LoginForm(MainForm mainForm)
        {
            string folderPath = @"C:/RepairRegistry";
            string filePath = Path.Combine(folderPath, "server_details");

            this.mainForm = mainForm; // Correctly store the reference
            InitializeComponent();

            if (!File.Exists(filePath))
            {
                ipBox.Visible = true;
                databaseBox.Visible = true;
                ipLabel.Visible = true;
                databaseLabel.Visible = true;
            }

            else
            {
                ipBox.Visible = false;
                databaseBox.Visible = false;
                ipLabel.Visible = false;
                databaseLabel.Visible = false;
            }
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Queries.setConnection(usernameTextBox.Text, passwordTextBox.Text) != null)
            {
                string folderPath = @"C:/RepairRegistry";
                string filePath = Path.Combine(folderPath, "server_details");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                if (!File.Exists(filePath))
                {
                    // Create the file if it doesn't exist
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine(ipBox.Text);
                        sw.WriteLine(databaseBox.Text);
                    }

                    Queries.ip = ipBox.Text;
                    Queries.database = databaseBox.Text;
                    
                }

                else
                {
                    string[] lines = File.ReadAllLines(filePath);
                    Queries.ip = lines[0];
                    Queries.database = lines[1];
                }

                Queries.username = usernameTextBox.Text;
                Queries.password = passwordTextBox.Text;


                mainForm.closeLogin(); // This should now correctly find closeLogin()
            }
        }
    }
}

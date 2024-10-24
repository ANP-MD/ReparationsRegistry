using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace RegistruReparatii
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm; // Class-level field
        private EditForm editForm;
        private string version = "1.0.0";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        public MainForm()
        {
            InitializeComponent();
            CheckUpdate(version);
            loginForm = new LoginForm(this); // Assign to the class-level field
            loginForm.TopLevel = false;
            loginForm.TopMost = true;
            mainPanel.Controls.Add(loginForm);
            loginForm.Show();
        }
        

        public void closeLogin()
        {
            loginForm.Close(); // This will work if loginForm is properly instantiated
            editForm = new EditForm(); // Assign to the class-level field
            editForm.TopLevel = false;
            editForm.TopMost = true;
            mainPanel.Controls.Add(editForm);
            editForm.Show();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        //update code
        public void CheckUpdate(string version)
        {
            try
            {
                var metadata = DownloadUpdateMetadata();
                if (version != metadata[0])
                {
                    var client = new WebClient();
                    client.DownloadFileCompleted += Client_DownloadFileCompleted;
                    client.DownloadFileAsync(new Uri(metadata[1]), Paths.update);
                }
                else
                {
                    File.Delete(Paths.update);
                }
            }
            catch
            {

            }
        }

        private List<string> DownloadUpdateMetadata()
        {
            using (var client = new WebClient())
            {
                var updateData = client.DownloadString(Paths.versionUrl);
                return new List<string>(Regex.Split(updateData, "\r\n|\r|\n"));
            }
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            File.WriteAllText(Paths.updateFlag, "INCOMING_UPDATE");
            var process = new Process { StartInfo = { FileName = Paths.update } };
            process.Start();
            Application.Exit();
        }
        //
    }
}

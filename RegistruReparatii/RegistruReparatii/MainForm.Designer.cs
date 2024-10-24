namespace RegistruReparatii
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainPanel = new Panel();
            topPanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            minimizeBtn = new Button();
            exitBtn = new Button();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(24, 30, 54);
            mainPanel.Dock = DockStyle.Bottom;
            mainPanel.Location = new Point(0, 37);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1371, 617);
            mainPanel.TabIndex = 0;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(66, 66, 66);
            topPanel.Controls.Add(pictureBox1);
            topPanel.Controls.Add(label1);
            topPanel.Controls.Add(minimizeBtn);
            topPanel.Controls.Add(exitBtn);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1371, 35);
            topPanel.TabIndex = 1;
            topPanel.MouseDown += topPanel_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3592847_general_office_repair_repair_tool_screwdriver_tools_wrench_107766;
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 17);
            label1.TabIndex = 2;
            label1.Text = "Reparations Registry V1.0.0 - Made by Caty";
            // 
            // minimizeBtn
            // 
            minimizeBtn.FlatStyle = FlatStyle.Flat;
            minimizeBtn.Font = new Font("Segoe UI", 10F);
            minimizeBtn.ForeColor = Color.Gainsboro;
            minimizeBtn.Location = new Point(1303, 3);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(25, 25);
            minimizeBtn.TabIndex = 1;
            minimizeBtn.Text = "-";
            minimizeBtn.UseVisualStyleBackColor = true;
            minimizeBtn.Click += minimizeBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI", 10F);
            exitBtn.ForeColor = Color.Gainsboro;
            exitBtn.Location = new Point(1334, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(25, 25);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 654);
            Controls.Add(topPanel);
            Controls.Add(mainPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "RegistruReparatii al ANP (CATALIN)";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel topPanel;
        private Button minimizeBtn;
        private Button exitBtn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

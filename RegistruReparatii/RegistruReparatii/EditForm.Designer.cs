namespace RegistruReparatii
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            backButton = new Button();
            editPanel = new Panel();
            lowerPanel = new Panel();
            institutionComboBox = new ComboBox();
            forwardStatisticsBtn = new Button();
            backStatisticsBtn = new Button();
            statisticsPageBtn = new Button();
            explorerBtn = new Button();
            statisticsBtn = new Button();
            pageButton = new Button();
            forwardBtn = new Button();
            refreshBtn = new Button();
            label1 = new Label();
            lowerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(24, 30, 54);
            btnSave.Font = new Font("Segoe UI", 10F);
            btnSave.ForeColor = Color.Gainsboro;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(288, 51);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(24, 30, 54);
            backButton.Font = new Font("Segoe UI", 10F);
            backButton.ForeColor = Color.Gainsboro;
            backButton.Location = new Point(297, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(61, 23);
            backButton.TabIndex = 3;
            backButton.Text = "<";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += previousPageBtn_Click;
            // 
            // editPanel
            // 
            editPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            editPanel.AutoSize = true;
            editPanel.BackColor = Color.FromArgb(24, 30, 54);
            editPanel.Font = new Font("Segoe UI", 10F);
            editPanel.ForeColor = Color.Gainsboro;
            editPanel.Location = new Point(0, 0);
            editPanel.Name = "editPanel";
            editPanel.Size = new Size(1371, 617);
            editPanel.TabIndex = 4;
            // 
            // lowerPanel
            // 
            lowerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lowerPanel.BackColor = Color.FromArgb(24, 30, 54);
            lowerPanel.Controls.Add(label1);
            lowerPanel.Controls.Add(institutionComboBox);
            lowerPanel.Controls.Add(forwardStatisticsBtn);
            lowerPanel.Controls.Add(backStatisticsBtn);
            lowerPanel.Controls.Add(statisticsPageBtn);
            lowerPanel.Controls.Add(explorerBtn);
            lowerPanel.Controls.Add(statisticsBtn);
            lowerPanel.Controls.Add(pageButton);
            lowerPanel.Controls.Add(forwardBtn);
            lowerPanel.Controls.Add(refreshBtn);
            lowerPanel.Controls.Add(btnSave);
            lowerPanel.Controls.Add(backButton);
            lowerPanel.Font = new Font("Segoe UI", 10F);
            lowerPanel.ForeColor = Color.Gainsboro;
            lowerPanel.Location = new Point(0, 560);
            lowerPanel.Name = "lowerPanel";
            lowerPanel.Size = new Size(1371, 57);
            lowerPanel.TabIndex = 5;
            // 
            // institutionComboBox
            // 
            institutionComboBox.BackColor = Color.FromArgb(24, 30, 54);
            institutionComboBox.Font = new Font("Segoe UI", 10F);
            institutionComboBox.ForeColor = Color.Gainsboro;
            institutionComboBox.FormattingEnabled = true;
            institutionComboBox.Location = new Point(851, 17);
            institutionComboBox.Name = "institutionComboBox";
            institutionComboBox.Size = new Size(172, 25);
            institutionComboBox.TabIndex = 13;
            institutionComboBox.SelectedIndexChanged += institutionComboBox_SelectedIndexChanged;
            // 
            // forwardStatisticsBtn
            // 
            forwardStatisticsBtn.BackColor = Color.FromArgb(24, 30, 54);
            forwardStatisticsBtn.Font = new Font("Segoe UI", 10F);
            forwardStatisticsBtn.ForeColor = Color.Gainsboro;
            forwardStatisticsBtn.Location = new Point(643, 3);
            forwardStatisticsBtn.Name = "forwardStatisticsBtn";
            forwardStatisticsBtn.Size = new Size(61, 23);
            forwardStatisticsBtn.TabIndex = 12;
            forwardStatisticsBtn.Text = ">";
            forwardStatisticsBtn.UseVisualStyleBackColor = false;
            forwardStatisticsBtn.Click += forwardStatisticsBtn_Click;
            // 
            // backStatisticsBtn
            // 
            backStatisticsBtn.BackColor = Color.FromArgb(24, 30, 54);
            backStatisticsBtn.Font = new Font("Segoe UI", 10F);
            backStatisticsBtn.ForeColor = Color.Gainsboro;
            backStatisticsBtn.Location = new Point(505, 3);
            backStatisticsBtn.Name = "backStatisticsBtn";
            backStatisticsBtn.Size = new Size(61, 23);
            backStatisticsBtn.TabIndex = 11;
            backStatisticsBtn.Text = "<";
            backStatisticsBtn.UseVisualStyleBackColor = false;
            backStatisticsBtn.Click += backStatisticsBtn_Click;
            // 
            // statisticsPageBtn
            // 
            statisticsPageBtn.BackColor = Color.FromArgb(24, 30, 54);
            statisticsPageBtn.Font = new Font("Segoe UI", 10F);
            statisticsPageBtn.ForeColor = Color.Gainsboro;
            statisticsPageBtn.Location = new Point(572, 3);
            statisticsPageBtn.Name = "statisticsPageBtn";
            statisticsPageBtn.Size = new Size(65, 23);
            statisticsPageBtn.TabIndex = 10;
            statisticsPageBtn.UseVisualStyleBackColor = false;
            // 
            // explorerBtn
            // 
            explorerBtn.BackColor = Color.FromArgb(24, 30, 54);
            explorerBtn.Font = new Font("Segoe UI", 10F);
            explorerBtn.ForeColor = Color.Gainsboro;
            explorerBtn.Location = new Point(297, 29);
            explorerBtn.Name = "explorerBtn";
            explorerBtn.Size = new Size(202, 25);
            explorerBtn.TabIndex = 9;
            explorerBtn.Text = "Explore";
            explorerBtn.UseVisualStyleBackColor = false;
            explorerBtn.Click += explorerBtn_Click;
            // 
            // statisticsBtn
            // 
            statisticsBtn.BackColor = Color.FromArgb(24, 30, 54);
            statisticsBtn.Font = new Font("Segoe UI", 10F);
            statisticsBtn.ForeColor = Color.Gainsboro;
            statisticsBtn.Location = new Point(505, 29);
            statisticsBtn.Name = "statisticsBtn";
            statisticsBtn.Size = new Size(202, 25);
            statisticsBtn.TabIndex = 8;
            statisticsBtn.Text = "Statistics";
            statisticsBtn.UseVisualStyleBackColor = false;
            statisticsBtn.Click += statisticsBtn_Click;
            // 
            // pageButton
            // 
            pageButton.BackColor = Color.FromArgb(24, 30, 54);
            pageButton.Font = new Font("Segoe UI", 10F);
            pageButton.ForeColor = Color.Gainsboro;
            pageButton.Location = new Point(364, 3);
            pageButton.Name = "pageButton";
            pageButton.Size = new Size(65, 23);
            pageButton.TabIndex = 6;
            pageButton.UseVisualStyleBackColor = false;
            // 
            // forwardBtn
            // 
            forwardBtn.BackColor = Color.FromArgb(24, 30, 54);
            forwardBtn.Font = new Font("Segoe UI", 10F);
            forwardBtn.ForeColor = Color.Gainsboro;
            forwardBtn.Location = new Point(438, 3);
            forwardBtn.Name = "forwardBtn";
            forwardBtn.Size = new Size(61, 23);
            forwardBtn.TabIndex = 5;
            forwardBtn.Text = ">";
            forwardBtn.UseVisualStyleBackColor = false;
            forwardBtn.Click += nextPageBtn_Click;
            // 
            // refreshBtn
            // 
            refreshBtn.BackColor = Color.FromArgb(24, 30, 54);
            refreshBtn.Font = new Font("Segoe UI", 10F);
            refreshBtn.ForeColor = Color.Gainsboro;
            refreshBtn.Location = new Point(1029, 3);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(339, 51);
            refreshBtn.TabIndex = 4;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = false;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(728, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 14;
            label1.Text = "Institution Filter";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 617);
            Controls.Add(lowerPanel);
            Controls.Add(editPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditForm";
            Text = "EditForm";
            lowerPanel.ResumeLayout(false);
            lowerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Button backButton;
        private Panel editPanel;
        private Panel lowerPanel;
        private Button refreshBtn;
        private Button forwardBtn;
        private Button pageButton;
        private Button statisticsBtn;
        private Button explorerBtn;
        private Button forwardStatisticsBtn;
        private Button backStatisticsBtn;
        private Button statisticsPageBtn;
        private ComboBox institutionComboBox;
        private Label label1;
    }
}
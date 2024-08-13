namespace IncidentManagementSystem.Forms
{
    partial class Admin_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel_choice = new System.Windows.Forms.Panel();
            this.button_branch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_list_reports = new System.Windows.Forms.Button();
            this.button_requests = new System.Windows.Forms.Button();
            this.button_home_admin = new System.Windows.Forms.Button();
            this.comboBoxHowManyDays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_slide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.main_panel);
            this.panel1.Controls.Add(this.panel_slide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 861);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.panel2.Location = new System.Drawing.Point(326, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 17);
            this.panel2.TabIndex = 4;
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.Location = new System.Drawing.Point(344, 26);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1027, 825);
            this.main_panel.TabIndex = 5;
            // 
            // panel_slide
            // 
            this.panel_slide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.panel_slide.Controls.Add(this.label1);
            this.panel_slide.Controls.Add(this.comboBoxHowManyDays);
            this.panel_slide.Controls.Add(this.label9);
            this.panel_slide.Controls.Add(this.panel_choice);
            this.panel_slide.Controls.Add(this.button_branch);
            this.panel_slide.Controls.Add(this.pictureBox1);
            this.panel_slide.Controls.Add(this.button_list_reports);
            this.panel_slide.Controls.Add(this.button_requests);
            this.panel_slide.Controls.Add(this.button_home_admin);
            this.panel_slide.Location = new System.Drawing.Point(0, 0);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(326, 871);
            this.panel_slide.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 800);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Przypominaj o zgłoszeniach zaległych o: ";
            // 
            // panel_choice
            // 
            this.panel_choice.BackColor = System.Drawing.SystemColors.Menu;
            this.panel_choice.Location = new System.Drawing.Point(316, 215);
            this.panel_choice.Name = "panel_choice";
            this.panel_choice.Size = new System.Drawing.Size(10, 85);
            this.panel_choice.TabIndex = 11;
            // 
            // button_branch
            // 
            this.button_branch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.button_branch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_branch.FlatAppearance.BorderSize = 0;
            this.button_branch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_branch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_branch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_branch.ForeColor = System.Drawing.Color.White;
            this.button_branch.Image = ((System.Drawing.Image)(resources.GetObject("button_branch.Image")));
            this.button_branch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_branch.Location = new System.Drawing.Point(0, 644);
            this.button_branch.Name = "button_branch";
            this.button_branch.Size = new System.Drawing.Size(324, 85);
            this.button_branch.TabIndex = 12;
            this.button_branch.Text = "Dział IT";
            this.button_branch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_branch.UseVisualStyleBackColor = true;
            this.button_branch.Click += new System.EventHandler(this.button_branch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-16, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button_list_reports
            // 
            this.button_list_reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_list_reports.FlatAppearance.BorderSize = 0;
            this.button_list_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_list_reports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_list_reports.ForeColor = System.Drawing.Color.White;
            this.button_list_reports.Image = ((System.Drawing.Image)(resources.GetObject("button_list_reports.Image")));
            this.button_list_reports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_list_reports.Location = new System.Drawing.Point(0, 498);
            this.button_list_reports.Name = "button_list_reports";
            this.button_list_reports.Size = new System.Drawing.Size(324, 85);
            this.button_list_reports.TabIndex = 14;
            this.button_list_reports.Text = "Lista zgłoszeń";
            this.button_list_reports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_list_reports.UseVisualStyleBackColor = true;
            this.button_list_reports.Click += new System.EventHandler(this.button_list_reports_Click);
            // 
            // button_requests
            // 
            this.button_requests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.button_requests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_requests.FlatAppearance.BorderSize = 0;
            this.button_requests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_requests.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_requests.ForeColor = System.Drawing.Color.White;
            this.button_requests.Image = ((System.Drawing.Image)(resources.GetObject("button_requests.Image")));
            this.button_requests.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_requests.Location = new System.Drawing.Point(0, 355);
            this.button_requests.Name = "button_requests";
            this.button_requests.Size = new System.Drawing.Size(324, 83);
            this.button_requests.TabIndex = 7;
            this.button_requests.Text = "Prośby";
            this.button_requests.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_requests.UseVisualStyleBackColor = false;
            this.button_requests.Click += new System.EventHandler(this.button_new_report_Click);
            // 
            // button_home_admin
            // 
            this.button_home_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home_admin.FlatAppearance.BorderSize = 0;
            this.button_home_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home_admin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_home_admin.ForeColor = System.Drawing.Color.White;
            this.button_home_admin.Image = ((System.Drawing.Image)(resources.GetObject("button_home_admin.Image")));
            this.button_home_admin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_home_admin.Location = new System.Drawing.Point(0, 215);
            this.button_home_admin.Name = "button_home_admin";
            this.button_home_admin.Size = new System.Drawing.Size(324, 85);
            this.button_home_admin.TabIndex = 11;
            this.button_home_admin.Text = "Strona główna";
            this.button_home_admin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_home_admin.UseVisualStyleBackColor = true;
            this.button_home_admin.Click += new System.EventHandler(this.button_home_admin_Click);
            // 
            // comboBoxHowManyDays
            // 
            this.comboBoxHowManyDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHowManyDays.FormattingEnabled = true;
            this.comboBoxHowManyDays.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "nie przypominaj"});
            this.comboBoxHowManyDays.Location = new System.Drawing.Point(12, 822);
            this.comboBoxHowManyDays.Name = "comboBoxHowManyDays";
            this.comboBoxHowManyDays.Size = new System.Drawing.Size(133, 29);
            this.comboBoxHowManyDays.TabIndex = 29;
            this.comboBoxHowManyDays.SelectedIndexChanged += new System.EventHandler(this.comboBoxHowManyDays_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 829);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "dni";
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 861);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.MinimumSize = new System.Drawing.Size(1400, 900);
            this.Name = "Admin_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Główny panel administratora";
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel_slide.ResumeLayout(false);
            this.panel_slide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Panel panel_choice;
        private System.Windows.Forms.Button button_branch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_list_reports;
        private System.Windows.Forms.Button button_requests;
        private System.Windows.Forms.Button button_home_admin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxHowManyDays;
        private System.Windows.Forms.Label label1;
    }
}
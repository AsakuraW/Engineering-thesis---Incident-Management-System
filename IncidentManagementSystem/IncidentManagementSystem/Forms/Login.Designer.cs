namespace IncidentManagementSystem
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label_title = new System.Windows.Forms.Label();
            this.pictureBox_ans_logo = new System.Windows.Forms.PictureBox();
            this.label_title2 = new System.Windows.Forms.Label();
            this.groupBox_login = new System.Windows.Forms.GroupBox();
            this.show_pass = new System.Windows.Forms.CheckBox();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.button_send_report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ans_logo)).BeginInit();
            this.groupBox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label_title.Location = new System.Drawing.Point(171, 390);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(335, 28);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "System Obsługi Incydentów";
            // 
            // pictureBox_ans_logo
            // 
            this.pictureBox_ans_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ans_logo.Image")));
            this.pictureBox_ans_logo.Location = new System.Drawing.Point(117, 187);
            this.pictureBox_ans_logo.Name = "pictureBox_ans_logo";
            this.pictureBox_ans_logo.Size = new System.Drawing.Size(414, 205);
            this.pictureBox_ans_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ans_logo.TabIndex = 1;
            this.pictureBox_ans_logo.TabStop = false;
            // 
            // label_title2
            // 
            this.label_title2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title2.AutoSize = true;
            this.label_title2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_title2.Location = new System.Drawing.Point(253, 423);
            this.label_title2.Name = "label_title2";
            this.label_title2.Size = new System.Drawing.Size(151, 19);
            this.label_title2.TabIndex = 0;
            this.label_title2.Text = "Dział IT ANS Elbląg";
            // 
            // groupBox_login
            // 
            this.groupBox_login.Controls.Add(this.show_pass);
            this.groupBox_login.Controls.Add(this.button_login);
            this.groupBox_login.Controls.Add(this.textBox_pass);
            this.groupBox_login.Controls.Add(this.label_pass);
            this.groupBox_login.Controls.Add(this.textBox_email);
            this.groupBox_login.Controls.Add(this.label_email);
            this.groupBox_login.Location = new System.Drawing.Point(587, 167);
            this.groupBox_login.Name = "groupBox_login";
            this.groupBox_login.Size = new System.Drawing.Size(345, 330);
            this.groupBox_login.TabIndex = 1;
            this.groupBox_login.TabStop = false;
            this.groupBox_login.Text = "Zaloguj się do systemu";
            // 
            // show_pass
            // 
            this.show_pass.AutoSize = true;
            this.show_pass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.show_pass.Location = new System.Drawing.Point(231, 168);
            this.show_pass.Name = "show_pass";
            this.show_pass.Size = new System.Drawing.Size(97, 21);
            this.show_pass.TabIndex = 3;
            this.show_pass.Text = "pokaż hasło";
            this.show_pass.UseVisualStyleBackColor = true;
            this.show_pass.CheckedChanged += new System.EventHandler(this.show_pass_CheckedChanged);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(23, 250);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(305, 50);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Zaloguj";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(23, 136);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(305, 27);
            this.textBox_pass.TabIndex = 1;
            this.textBox_pass.UseSystemPasswordChar = true;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label_pass.Location = new System.Drawing.Point(19, 114);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(55, 19);
            this.label_pass.TabIndex = 1;
            this.label_pass.Text = "hasło:";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(23, 70);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(305, 27);
            this.textBox_email.TabIndex = 0;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label_email.Location = new System.Drawing.Point(19, 48);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(84, 19);
            this.label_email.TabIndex = 0;
            this.label_email.Text = "Login sali:";
            // 
            // button_send_report
            // 
            this.button_send_report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_send_report.BackColor = System.Drawing.Color.White;
            this.button_send_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_send_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send_report.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_send_report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.button_send_report.Location = new System.Drawing.Point(983, 604);
            this.button_send_report.Margin = new System.Windows.Forms.Padding(4);
            this.button_send_report.Name = "button_send_report";
            this.button_send_report.Size = new System.Drawing.Size(187, 63);
            this.button_send_report.TabIndex = 19;
            this.button_send_report.Text = "Prośba przygotowania sali";
            this.button_send_report.UseVisualStyleBackColor = false;
            this.button_send_report.Click += new System.EventHandler(this.button_send_report_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.button_send_report);
            this.Controls.Add(this.groupBox_login);
            this.Controls.Add(this.pictureBox_ans_logo);
            this.Controls.Add(this.label_title2);
            this.Controls.Add(this.label_title);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ans_logo)).EndInit();
            this.groupBox_login.ResumeLayout(false);
            this.groupBox_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.PictureBox pictureBox_ans_logo;
        private System.Windows.Forms.Label label_title2;
        private System.Windows.Forms.GroupBox groupBox_login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.CheckBox show_pass;
        private System.Windows.Forms.Button button_send_report;
    }
}


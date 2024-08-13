namespace IncidentManagementSystem.UserControls
{
    partial class UC_change_password
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_send_report = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_title2 = new System.Windows.Forms.Label();
            this.textBox_new_pass_rep = new System.Windows.Forms.TextBox();
            this.textBox_old_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_new_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_send_report);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 819);
            this.panel1.TabIndex = 0;
            // 
            // button_send_report
            // 
            this.button_send_report.BackColor = System.Drawing.Color.White;
            this.button_send_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_send_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send_report.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_send_report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.button_send_report.Location = new System.Drawing.Point(402, 640);
            this.button_send_report.Margin = new System.Windows.Forms.Padding(5);
            this.button_send_report.Name = "button_send_report";
            this.button_send_report.Size = new System.Drawing.Size(230, 81);
            this.button_send_report.TabIndex = 13;
            this.button_send_report.Text = " Zmień";
            this.button_send_report.UseVisualStyleBackColor = false;
            this.button_send_report.Click += new System.EventHandler(this.button_send_report_Click);
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label_title.Location = new System.Drawing.Point(334, 48);
            this.label_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(374, 38);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Zmiana hasła do konta";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label_title2);
            this.panel2.Controls.Add(this.textBox_new_pass_rep);
            this.panel2.Controls.Add(this.textBox_old_pass);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox_new_pass);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(274, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 481);
            this.panel2.TabIndex = 14;
            // 
            // label_title2
            // 
            this.label_title2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title2.AutoSize = true;
            this.label_title2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_title2.Location = new System.Drawing.Point(170, 94);
            this.label_title2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_title2.Name = "label_title2";
            this.label_title2.Size = new System.Drawing.Size(139, 23);
            this.label_title2.TabIndex = 3;
            this.label_title2.Text = "Bieżące hasło";
            // 
            // textBox_new_pass_rep
            // 
            this.textBox_new_pass_rep.Location = new System.Drawing.Point(128, 336);
            this.textBox_new_pass_rep.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_new_pass_rep.Name = "textBox_new_pass_rep";
            this.textBox_new_pass_rep.Size = new System.Drawing.Size(230, 27);
            this.textBox_new_pass_rep.TabIndex = 8;
            this.textBox_new_pass_rep.UseSystemPasswordChar = true;
            // 
            // textBox_old_pass
            // 
            this.textBox_old_pass.Location = new System.Drawing.Point(128, 129);
            this.textBox_old_pass.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_old_pass.Name = "textBox_old_pass";
            this.textBox_old_pass.Size = new System.Drawing.Size(230, 27);
            this.textBox_old_pass.TabIndex = 6;
            this.textBox_old_pass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(149, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Powtórz nowe hasło";
            // 
            // textBox_new_pass
            // 
            this.textBox_new_pass.Location = new System.Drawing.Point(128, 242);
            this.textBox_new_pass.Margin = new System.Windows.Forms.Padding(5);
            this.textBox_new_pass.Name = "textBox_new_pass";
            this.textBox_new_pass.Size = new System.Drawing.Size(230, 27);
            this.textBox_new_pass.TabIndex = 7;
            this.textBox_new_pass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(184, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nowe hasło";
            // 
            // UC_change_password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UC_change_password";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1045, 829);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_old_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_title2;
        private System.Windows.Forms.TextBox textBox_new_pass_rep;
        private System.Windows.Forms.TextBox textBox_new_pass;
        private System.Windows.Forms.Button button_send_report;
        private System.Windows.Forms.Panel panel2;
    }
}

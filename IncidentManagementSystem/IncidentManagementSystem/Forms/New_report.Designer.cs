namespace IncidentManagementSystem.Forms
{
    partial class New_report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_building = new System.Windows.Forms.TextBox();
            this.button_send_report = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBox_report_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_place = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_report_title = new System.Windows.Forms.TextBox();
            this.label_title2 = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_building);
            this.panel1.Controls.Add(this.button_send_report);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.textBox_report_description);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_place);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_report_title);
            this.panel1.Controls.Add(this.label_title2);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 835);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(562, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Budynek:";
            // 
            // textBox_building
            // 
            this.textBox_building.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_building.Location = new System.Drawing.Point(651, 147);
            this.textBox_building.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_building.MaxLength = 3;
            this.textBox_building.Name = "textBox_building";
            this.textBox_building.ReadOnly = true;
            this.textBox_building.Size = new System.Drawing.Size(93, 23);
            this.textBox_building.TabIndex = 13;
            // 
            // button_send_report
            // 
            this.button_send_report.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_send_report.BackColor = System.Drawing.Color.White;
            this.button_send_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_send_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_send_report.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_send_report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.button_send_report.Location = new System.Drawing.Point(590, 704);
            this.button_send_report.Margin = new System.Windows.Forms.Padding(4);
            this.button_send_report.Name = "button_send_report";
            this.button_send_report.Size = new System.Drawing.Size(184, 65);
            this.button_send_report.TabIndex = 12;
            this.button_send_report.Text = "Wyślij";
            this.button_send_report.UseVisualStyleBackColor = false;
            this.button_send_report.Click += new System.EventHandler(this.button_send_report_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cancel.BackColor = System.Drawing.Color.White;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cancel.ForeColor = System.Drawing.Color.Brown;
            this.button_cancel.Location = new System.Drawing.Point(371, 704);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(184, 65);
            this.button_cancel.TabIndex = 11;
            this.button_cancel.Text = "Anuluj";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(248, 140);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(241, 25);
            this.comboBoxType.TabIndex = 9;
            // 
            // textBox_report_description
            // 
            this.textBox_report_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_report_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_report_description.Location = new System.Drawing.Point(50, 331);
            this.textBox_report_description.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_report_description.MaxLength = 500;
            this.textBox_report_description.Multiline = true;
            this.textBox_report_description.Name = "textBox_report_description";
            this.textBox_report_description.Size = new System.Drawing.Size(724, 325);
            this.textBox_report_description.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(44, 292);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Treść";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(562, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sala:";
            // 
            // textBox_place
            // 
            this.textBox_place.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_place.Location = new System.Drawing.Point(651, 178);
            this.textBox_place.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_place.MaxLength = 3;
            this.textBox_place.Name = "textBox_place";
            this.textBox_place.ReadOnly = true;
            this.textBox_place.Size = new System.Drawing.Size(93, 23);
            this.textBox_place.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(45, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tytuł zgłoszenia:";
            // 
            // textBox_report_title
            // 
            this.textBox_report_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_report_title.Location = new System.Drawing.Point(248, 182);
            this.textBox_report_title.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_report_title.MaxLength = 50;
            this.textBox_report_title.Name = "textBox_report_title";
            this.textBox_report_title.Size = new System.Drawing.Size(241, 23);
            this.textBox_report_title.TabIndex = 3;
            // 
            // label_title2
            // 
            this.label_title2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title2.AutoSize = true;
            this.label_title2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label_title2.Location = new System.Drawing.Point(45, 140);
            this.label_title2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title2.Name = "label_title2";
            this.label_title2.Size = new System.Drawing.Size(146, 19);
            this.label_title2.TabIndex = 2;
            this.label_title2.Text = "Rodzaj problemu:";
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label_title.Location = new System.Drawing.Point(286, 18);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(278, 38);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Nowe zgłoszenie";
            // 
            // New_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(852, 854);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_report";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.New_report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBox_report_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_place;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_report_title;
        private System.Windows.Forms.Label label_title2;
        private System.Windows.Forms.Button button_send_report;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_building;
    }
}
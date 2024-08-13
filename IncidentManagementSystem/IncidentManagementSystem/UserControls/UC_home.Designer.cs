namespace IncidentManagementSystem.UserControls
{
    partial class UC_home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_info = new System.Windows.Forms.Label();
            this.panel_info = new System.Windows.Forms.Panel();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBoxDataStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label_done_reports = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_active_reports = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_info.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.chart1);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1017, 815);
            this.panel7.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(619, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 423);
            this.panel3.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label_info);
            this.groupBox1.Controls.Add(this.panel_info);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 410);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ostatnie zgłoszenie";
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(120, 188);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(114, 21);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "Brak zgłoszeń";
            // 
            // panel_info
            // 
            this.panel_info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_info.Controls.Add(this.buttonStatus);
            this.panel_info.Controls.Add(this.label6);
            this.panel_info.Controls.Add(this.panel12);
            this.panel_info.Controls.Add(this.panel11);
            this.panel_info.Controls.Add(this.label4);
            this.panel_info.Controls.Add(this.label2);
            this.panel_info.Controls.Add(this.panel10);
            this.panel_info.Controls.Add(this.label1);
            this.panel_info.Location = new System.Drawing.Point(6, 26);
            this.panel_info.Name = "panel_info";
            this.panel_info.Size = new System.Drawing.Size(337, 378);
            this.panel_info.TabIndex = 1;
            // 
            // buttonStatus
            // 
            this.buttonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatus.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStatus.ForeColor = System.Drawing.Color.Red;
            this.buttonStatus.Location = new System.Drawing.Point(156, 342);
            this.buttonStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(86, 24);
            this.buttonStatus.TabIndex = 42;
            this.buttonStatus.Text = "button1";
            this.buttonStatus.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label6.Location = new System.Drawing.Point(94, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Status: ";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel12.Controls.Add(this.textBox_description);
            this.panel12.Location = new System.Drawing.Point(18, 227);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(5);
            this.panel12.Size = new System.Drawing.Size(304, 107);
            this.panel12.TabIndex = 40;
            // 
            // textBox_description
            // 
            this.textBox_description.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_description.Location = new System.Drawing.Point(5, 5);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ReadOnly = true;
            this.textBox_description.Size = new System.Drawing.Size(294, 97);
            this.textBox_description.TabIndex = 29;
            this.textBox_description.Text = "dasdas";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.textBoxDataStart);
            this.panel11.Location = new System.Drawing.Point(18, 44);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(5);
            this.panel11.Size = new System.Drawing.Size(304, 38);
            this.panel11.TabIndex = 39;
            // 
            // textBoxDataStart
            // 
            this.textBoxDataStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxDataStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDataStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDataStart.Location = new System.Drawing.Point(5, 5);
            this.textBoxDataStart.Multiline = true;
            this.textBoxDataStart.Name = "textBoxDataStart";
            this.textBoxDataStart.ReadOnly = true;
            this.textBoxDataStart.Size = new System.Drawing.Size(294, 28);
            this.textBoxDataStart.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(14, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Treść:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Data złożenia:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel10.Controls.Add(this.textBoxTitle);
            this.panel10.Location = new System.Drawing.Point(18, 123);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(5);
            this.panel10.Size = new System.Drawing.Size(304, 67);
            this.panel10.TabIndex = 35;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTitle.Location = new System.Drawing.Point(5, 5);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(294, 57);
            this.textBoxTitle.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(14, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tytuł:";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend1.TitleFont = new System.Drawing.Font("Century Gothic", 12F);
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(37, 514);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Century Gothic", 12F);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(949, 278);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "Liczba zgłoszen";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Location = new System.Drawing.Point(65, 379);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 10);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Location = new System.Drawing.Point(65, 185);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(459, 10);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label_done_reports);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(65, 278);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(459, 111);
            this.panel6.TabIndex = 7;
            // 
            // label_done_reports
            // 
            this.label_done_reports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_done_reports.AutoSize = true;
            this.label_done_reports.BackColor = System.Drawing.Color.Transparent;
            this.label_done_reports.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_done_reports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label_done_reports.Location = new System.Drawing.Point(205, 36);
            this.label_done_reports.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_done_reports.Name = "label_done_reports";
            this.label_done_reports.Size = new System.Drawing.Size(61, 44);
            this.label_done_reports.TabIndex = 4;
            this.label_done_reports.Text = "10";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(16, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rozwiązane zgłoszenia:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_active_reports);
            this.panel2.Controls.Add(this.label_title);
            this.panel2.Location = new System.Drawing.Point(65, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 111);
            this.panel2.TabIndex = 5;
            // 
            // label_active_reports
            // 
            this.label_active_reports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_active_reports.AutoSize = true;
            this.label_active_reports.BackColor = System.Drawing.Color.Transparent;
            this.label_active_reports.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_active_reports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label_active_reports.Location = new System.Drawing.Point(205, 36);
            this.label_active_reports.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_active_reports.Name = "label_active_reports";
            this.label_active_reports.Size = new System.Drawing.Size(61, 44);
            this.label_active_reports.TabIndex = 4;
            this.label_active_reports.Text = "10";
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.label_title.Location = new System.Drawing.Point(16, 13);
            this.label_title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(165, 19);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Aktywne zgłoszenia:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.ForeColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(33, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(519, 420);
            this.panel8.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(33, 508);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(957, 297);
            this.panel9.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 815);
            this.panel1.TabIndex = 0;
            // 
            // UC_home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Name = "UC_home";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1027, 825);
            this.Load += new System.EventHandler(this.UC_home_Load);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_info.ResumeLayout(false);
            this.panel_info.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label_done_reports;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_active_reports;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Panel panel_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDataStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonStatus;
    }
}

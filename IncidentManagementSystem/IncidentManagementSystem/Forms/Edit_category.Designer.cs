namespace IncidentManagementSystem.Forms
{
    partial class Edit_category
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
            this.button_save = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBoxIfHidden = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewNameCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOldNameCategory = new System.Windows.Forms.TextBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.checkBoxIfHidden);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxNewNameCategory);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxOldNameCategory);
            this.panel1.Controls.Add(this.labelMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 279);
            this.panel1.TabIndex = 0;
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_save.BackColor = System.Drawing.Color.White;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.button_save.Location = new System.Drawing.Point(372, 232);
            this.button_save.Margin = new System.Windows.Forms.Padding(4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(111, 34);
            this.button_save.TabIndex = 67;
            this.button_save.Text = "Zapisz";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cancel.BackColor = System.Drawing.Color.White;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cancel.ForeColor = System.Drawing.Color.Brown;
            this.button_cancel.Location = new System.Drawing.Point(199, 232);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(111, 34);
            this.button_cancel.TabIndex = 68;
            this.button_cancel.Text = "Anuluj";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // checkBoxIfHidden
            // 
            this.checkBoxIfHidden.AutoSize = true;
            this.checkBoxIfHidden.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxIfHidden.Location = new System.Drawing.Point(223, 191);
            this.checkBoxIfHidden.Name = "checkBoxIfHidden";
            this.checkBoxIfHidden.Size = new System.Drawing.Size(62, 21);
            this.checkBoxIfHidden.TabIndex = 66;
            this.checkBoxIfHidden.Text = "Ukryty";
            this.checkBoxIfHidden.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(219, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nowa nazwa";
            // 
            // textBoxNewNameCategory
            // 
            this.textBoxNewNameCategory.Location = new System.Drawing.Point(223, 156);
            this.textBoxNewNameCategory.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxNewNameCategory.Name = "textBoxNewNameCategory";
            this.textBoxNewNameCategory.Size = new System.Drawing.Size(241, 27);
            this.textBoxNewNameCategory.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(219, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bieżąca nazwa";
            // 
            // textBoxOldNameCategory
            // 
            this.textBoxOldNameCategory.Location = new System.Drawing.Point(223, 96);
            this.textBoxOldNameCategory.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxOldNameCategory.Name = "textBoxOldNameCategory";
            this.textBoxOldNameCategory.ReadOnly = true;
            this.textBoxOldNameCategory.Size = new System.Drawing.Size(241, 27);
            this.textBoxOldNameCategory.TabIndex = 21;
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.labelMain.Location = new System.Drawing.Point(217, 11);
            this.labelMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(247, 36);
            this.labelMain.TabIndex = 18;
            this.labelMain.Text = "Edytuj kategorie";
            // 
            // Edit_category
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(68)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(692, 289);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_category";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edycja kategorii";
            this.Load += new System.EventHandler(this.Edit_category_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.TextBox textBoxOldNameCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewNameCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxIfHidden;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
    }
}
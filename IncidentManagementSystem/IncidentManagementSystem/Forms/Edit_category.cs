using SLRDbConnector;
using System;
using System.Windows.Forms;


namespace IncidentManagementSystem.Forms
{
    public partial class Edit_category : Form
    {
        DbConnector db;
        private string categoryId;
        public Edit_category(string cid)
        {
            InitializeComponent();
            categoryId = cid;
            db = new DbConnector();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            int isHidden;

            if (textBoxNewNameCategory.Text.Trim() != string.Empty)
            {
                if (checkBoxIfHidden.Checked) isHidden = 1; else isHidden = 0;
                string name = db.getSingleValue("select name from Type where name = '" + textBoxNewNameCategory.Text + "'", out name, 0);

                if(textBoxNewNameCategory.Text.Trim() != name) 
                { 

                    DialogResult dr = MessageBox.Show("Czy na pewno chcesz zapisać zmiany?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Pomyślnie zapisano zmiany", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.performCRUD("update Type set is_hidden = "+isHidden+", name = '"+textBoxNewNameCategory.Text+"' where idType = "+Convert.ToInt32(categoryId));
                        this.Dispose();
                    }
                }
                else MessageBox.Show("Podana nazwa istnieje już na liście", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Pole z nową nazwą nie może zostać puste", "Puste pole", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Edit_category_Load(object sender, EventArgs e)
        {
            string categoryName = db.getSingleValue("select name from Type where idType = "+Convert.ToInt32(categoryId), out categoryName, 0);
            textBoxOldNameCategory.Text = categoryName;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

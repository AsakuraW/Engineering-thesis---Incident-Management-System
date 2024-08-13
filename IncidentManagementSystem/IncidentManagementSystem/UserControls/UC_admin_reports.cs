using IncidentManagementSystem.Forms;
using SLRDbConnector;
using System;
using System.Windows.Forms;

namespace IncidentManagementSystem.UserControls
{
    public partial class UC_admin_reports : UserControl
    {
        DbConnector db;
        private string troubleId;
       
        public UC_admin_reports()
        {
            InitializeComponent();
            db = new DbConnector();
        }
      
        private void UC_admin_reports_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 1 order by start_date asc", dataGridView1);
            db.fillDataGridView("select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 2 order by start_date asc", dataGridView2);
            db.fillDataGridView("select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 3 order by start_date asc", dataGridView3);
            button_details.Enabled = false;
            button_sent_to_realization.Enabled = false;
            button_done.Enabled = false;
            button_del_report.Enabled = false;

        }
       
        private void GetTroubleId(int rowIndex, DataGridView dataGridView)
        {
            button_details.Enabled = true;
            button_del_report.Enabled = true;

            button_sent_to_realization.Enabled = (dataGridView == dataGridView1); // tylko dla dataGridView1
            button_done.Enabled = (dataGridView == dataGridView2); // tylko dla dataGridView2

            if (rowIndex >= 0)
            {
                troubleId = dataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetTroubleId(e.RowIndex,dataGridView1);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetTroubleId(e.RowIndex, dataGridView2);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetTroubleId(e.RowIndex, dataGridView3);
        }
     


        private void button_sent_to_realization_Click(object sender, EventArgs e)
        {

            if (!troubleId.Equals(String.Empty))
            {
                using (Send_to_realization sr = new Send_to_realization(troubleId))
                {
                    sr.ShowDialog();
                    this.OnLoad(e);
                }
              
            }
        }
     
        private void button_details_Click(object sender, EventArgs e)
        {
            if (!troubleId.Equals(String.Empty))
            {
                using (Admin_Details ad = new Admin_Details(troubleId))
                {
                    ad.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            if(tabControl1.SelectedTab == tabPage1)
            {
                if (comboBox_searchBy.SelectedItem.Equals("ID"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 1 AND idTroubles = " + textBox_search.Text;
                }
                if (comboBox_searchBy.SelectedItem.Equals("Identyfikator"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 1 AND u.email LIKE '%" + textBox_search.Text + "%'";
                }
                if (comboBox_searchBy.SelectedItem.Equals("Temat"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 1 AND subiect LIKE '%" + textBox_search.Text + "%'";
                }

                if (comboBox_searchBy.SelectedItem.Equals("Kategoria"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 1 AND ty.name LIKE '%" + textBox_search.Text + "%'";
                }

                if (comboBox_searchBy.SelectedItem.Equals("Data"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 1 AND start_date LIKE '%" + textBox_search.Text.ToString() + "%'";
                }
                if (tabControl1.SelectedTab == tabPage1) db.fillDataGridView(query, dataGridView1);
            }

            if (tabControl1.SelectedTab == tabPage2)
            {
                if (comboBox_searchBy.SelectedItem.Equals("ID"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 2 AND idTroubles = " + textBox_search.Text;
                }
                if (comboBox_searchBy.SelectedItem.Equals("Identyfikator"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 2 AND u.email LIKE '%" + textBox_search.Text + "%'";
                }
                if (comboBox_searchBy.SelectedItem.Equals("Temat"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 2 AND subiect LIKE '%" + textBox_search.Text + "%'";
                }

                if (comboBox_searchBy.SelectedItem.Equals("Kategoria"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 2 AND ty.name LIKE '%" + textBox_search.Text + "%'";
                }

                if (comboBox_searchBy.SelectedItem.Equals("Data"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 2 AND start_date LIKE '%" + textBox_search.Text.ToString() + "%'";
                }
                if (tabControl1.SelectedTab == tabPage2) db.fillDataGridView(query, dataGridView2);
            }


            if (tabControl1.SelectedTab == tabPage3)
            {
                if (comboBox_searchBy.SelectedItem.Equals("ID"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 3 AND idTroubles = " + textBox_search.Text;
                }
                if (comboBox_searchBy.SelectedItem.Equals("Identyfikator"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 3 AND u.email LIKE '%" + textBox_search.Text + "%'";
                }
                if (comboBox_searchBy.SelectedItem.Equals("Temat"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 3 AND subiect LIKE '%" + textBox_search.Text + "%'";
                }

                if (comboBox_searchBy.SelectedItem.Equals("Kategoria"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 3 AND ty.name LIKE '%" + textBox_search.Text + "%'";
                }

                if (comboBox_searchBy.SelectedItem.Equals("Data"))
                {
                    query = "select t.idTroubles as ID, u.email as 'Identyfikator', t.subiect as Temat,ty.name as Kategoria, t.start_date as 'Data zgłoszenia' from Troubles t join Users u on t.Users_idUsers = u.idUsers join Type ty on t.Type_idType = ty.idType where Status_idStatus = 3 AND start_date LIKE '%" + textBox_search.Text.ToString() + "%'";
                }
                if (tabControl1.SelectedTab == tabPage3) db.fillDataGridView(query, dataGridView3);
            }



            if (textBox_search.Text == "")
            {
                this.OnLoad(e);
            }
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno zakończyć realizację zgłoszenia?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {

                string data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                MessageBox.Show("Pomyślnie zakończono zgłoszenie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                db.performCRUD("update Troubles set Status_idStatus = 3, end_date = '"+ data +"' where idTroubles = " + Convert.ToInt32(troubleId));
                this.OnLoad(e);
            }
        }

        private void button_del_report_Click(object sender, EventArgs e)
        {
            if (!troubleId.Equals(String.Empty))
            {
                DialogResult dr = MessageBox.Show("Czy na pewno usunąć zgłoszenie o ID "+troubleId+"?\n\n Spowoduje to nieodwracalne wymazanie informacji o tym zgłoszeniu. Ty oraz zgłaszający nie będą mieć więcej możliwości podglądu tych danych.", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Pomyślnie usunięto zgłoszenie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.performCRUD("delete from Troubles where idTroubles = " + Convert.ToInt32(troubleId));
                    this.OnLoad(e);
                }

            }
        }
    }
}


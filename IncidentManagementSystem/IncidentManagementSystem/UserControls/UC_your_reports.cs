using IncidentManagementSystem.Forms;
using SLRDbConnector;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IncidentManagementSystem.UserControls
{
    public partial class UC_your_reports : UserControl
    {
        DbConnector db;
        private string userId;
        private string troubleId;
        
        public UC_your_reports(string id)
        {
            InitializeComponent();
            db = new DbConnector();
            userId = id;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244,244, 244) ;
          



        }

        private void UC_your_reports_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select t.idTroubles as ID, t.subiect as Temat, s.name as Status, t.start_date as 'Data zgłoszenia' from Troubles t join Status s on t.Status_idStatus = s.idStatus where t.Users_idUsers=" + Convert.ToInt32(userId),dataGridView1);
            button_details.Enabled = false;
            
        }

      

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            
            string query = "";
            if (comboBox_searchBy.SelectedItem.Equals("ID"))
            {
                query = "select t.idTroubles as ID, t.subiect as Temat, s.name as Status, t.start_date as 'Data zgłoszenia' from Troubles t join Status s on t.Status_idStatus = s.idStatus where t.Users_idUsers=" + Convert.ToInt32(userId) + "AND idTroubles = " + textBox_search.Text;
            }
            if (comboBox_searchBy.SelectedItem.Equals("Temat"))
            {
                query = "select t.idTroubles as ID, t.subiect as Temat, s.name as Status, t.start_date as 'Data zgłoszenia' from Troubles t join Status s on t.Status_idStatus = s.idStatus where t.Users_idUsers=" + Convert.ToInt32(userId) + "AND subiect LIKE '%"+textBox_search.Text+"%'";

            }
            if (comboBox_searchBy.SelectedItem.Equals("Data"))
            {
                query = "select t.idTroubles as ID, t.subiect as Temat, s.name as Status, t.start_date as 'Data zgłoszenia' from Troubles t join Status s on t.Status_idStatus = s.idStatus where t.Users_idUsers=" + Convert.ToInt32(userId) + "AND start_date LIKE '%" +textBox_search.Text.ToString()+ "%'";

            }
            db.fillDataGridView(query,dataGridView1);

            if (textBox_search.Text == "")
            {
                this.OnLoad(e);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_details.Enabled = true;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                troubleId = row.Cells[0].Value.ToString();
            }
        }

        private void button_details_Click(object sender, EventArgs e)
        {

            if (!troubleId.Equals(String.Empty))
            {
                using (Details dt = new Details(userId,troubleId))
                {
                    dt.ShowDialog();
                }
            } 
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Status"].Index && e.Value != null)
            {
                if (e.Value.ToString() == "oczekujące")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
                else if (e.Value.ToString() == "w realizacji")
                {
                    e.CellStyle.ForeColor = Color.Orange;
                }
                else if (e.Value.ToString() == "zakończono")
                {
                    e.CellStyle.ForeColor = Color.Green;
                }
            }
        }
    }
}

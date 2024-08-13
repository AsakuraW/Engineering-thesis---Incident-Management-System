using SLRDbConnector;
using System;
using System.Windows.Forms;

namespace IncidentManagementSystem.Forms
{
    public partial class New_report : Form
    {
        private string userId;
        DbConnector db;
        
        public New_report(string id)
        {
            InitializeComponent();
            db = new DbConnector();
            userId = id;

        }

        private void New_report_Load(object sender, EventArgs e)
        {
            string place = db.getSingleValue("SELECT SUBSTRING(email, 4, 3) as place FROM users where idUsers = "+userId, out place, 0);
            string building = db.getSingleValue("SELECT SUBSTRING(email, 2, 1) AS building FROM users where idUsers = " + userId, out building, 0);
            db.FillCombobox("select name from Type where is_hidden=0", comboBoxType);
            textBox_place.Text = place;
            textBox_building.Text= building;
        }

        private void button_send_report_Click(object sender, EventArgs e)
        {
            if (isFormValid())
            {
                insertData();
            }
        }

        private void insertData()
        {
            DialogResult dr = MessageBox.Show("Czy na pewno wysłać zgłoszenie?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string typeId = db.getSingleValue("Select idType from Type where name='" + comboBoxType.Text + "'", out typeId, 0);
                db.performCRUD("insert into Troubles (Users_idUsers,Type_idType,subiect,description,place,building,start_date,Status_idStatus) VALUES ("+Convert.ToInt32(userId)+","+Convert.ToInt32(typeId)+",'"+textBox_report_title.Text+"','"+textBox_report_description.Text+"','"+textBox_place.Text+"','" + textBox_building.Text + "','" + data+ "',1)");
                MessageBox.Show("Pomyślnie wysłano zgłoszenie","Sukces",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
                

            }
        }

        private bool isFormValid()
        {
            double number;
            bool isNumber = double.TryParse(textBox_place.Text, out number);
            if (isNumber)
            {
                if (textBox_report_title.Text.Trim() == string.Empty ||
                            textBox_place.Text.Trim() == string.Empty ||
                            textBox_report_description.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Wypełnij wszystkie pola, aby poprawnie wysłać zgłoszenie", "Puste pola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Podaj poprawny numer sali", "Zły numer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

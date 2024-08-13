using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IncidentManagementSystem.Forms
{
    public partial class Logout_request : Form
    {
        DbConnector db;
        public Logout_request()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void button_send_request_Click(object sender, EventArgs e)
        {
            if (FieldsValid())
            {
                if(comboBoxBuilding.SelectedItem != null) { 
                    
                        insertData();
                    
                }
                else MessageBox.Show("Wybierz budynek", "Puste pole", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void insertData()
        {
            if (checkedListBox1.CheckedItems.Count == 0 && !checkBox7.Checked)
            {
                MessageBox.Show("Wybierz przynajmniej jeden program", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Czy na pewno wysłać prośbę?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) 
            {
                string setBuilding = "";
                string checkboxFields = "";

                foreach (string item in checkedListBox1.CheckedItems)
                {
                    checkboxFields += item + ",";
                }
                if (checkBox7.Checked && textBox1.Text.Trim() != string.Empty) checkboxFields += textBox1.Text + ",";
                else
                { MessageBox.Show("Wybierając pole INNE podaj nazwę programu", "Nie podano nazwy programu", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }


                checkboxFields = checkboxFields.TrimEnd(new char[] { ',' });


                if (comboBoxBuilding.Text == "Al. Grunwaldzka 137") setBuilding = "1";
                if (comboBoxBuilding.Text == "ul. Czerniakowska 22") setBuilding = "2";
                if (comboBoxBuilding.Text == "ul. Wojska Polskiego 1") setBuilding = "3";

                DateTime date_end = dateTimePicker1.Value;
                string data_end = date_end.ToString("yyyy-MM-dd HH:mm:ss");
                string data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                db.performCRUD("insert into Request (email,date_start,place,building,date_end,programs) VALUES ('" + textBox_email.Text + "','" +data+ "','" + textBox_place.Text + "','"+ setBuilding + "','" + data_end + "','" +checkboxFields + "')");
                MessageBox.Show("Pomyślnie wysłano prośbę", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }  
        }


       

        private bool FieldsValid()
        {
            double number;
            bool isNumber = double.TryParse(textBox_place.Text, out number);
           if(EmailValidation(textBox_email.Text)) 
            { 

            if (isNumber) { return true; }
            else
            {
                MessageBox.Show("Podaj poprawny numer sali", "Zły numer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            }else return false;

        }

        private bool EmailValidation(string email)
        {
            if (textBox_email.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Pole z adresem email nie może zostać puste", "Puste pole", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // sprawdzenie czy adres zawiera dokładnie jeden znak @
            int atCount = email.Count(c => c == '@');
            if (atCount != 1)
            {
                MessageBox.Show("Niepoprawna składnia adresu email", "Błąd składni email", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;

            }

            // sprawdzenie czy nazwa użytkownika (przed @) jest poprawna
            string[] emailParts = email.Split('@');
            string username = emailParts[0];
            if (username.Length < 1 || username.Length > 64)
            {
                return false;
            }
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9!#$%&'*+\/=?^_`{|}~-]+(\.[a-zA-Z0-9!#$%&'*+\/=?^_`{|}~-]+)*$"))
            {
                MessageBox.Show("Niepoprawna składnia adresu email", "Błąd składni email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // sprawdzenie czy nazwa domeny (po @) jest poprawna
            string domain = emailParts[1];
            if (domain.Length < 1 || domain.Length > 255)
            {
                return false;
            }
            if (!Regex.IsMatch(domain, @"^([a-zA-Z0-9_-]+\.)*[a-zA-Z0-9_-]+\.[a-zA-Z]{2,6}$"))
            {
                MessageBox.Show("Niepoprawna domena adresu email", "Błąd domeny email", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Logout_request_Load(object sender, EventArgs e)
        {
            string query = "SELECT name FROM programs_for_checkboxs ORDER BY idPrograms_for_checkboxs ASC";
            List<string> programNames = new List<string>();

            string list_of_programs = db.GetSingleValueByArray("SELECT name FROM programs_for_checkboxs ORDER BY idPrograms_for_checkboxs ASC", out programNames, 0);


            foreach (string programName in programNames)
            {
                if (!string.IsNullOrEmpty(programName))
                {
                    checkedListBox1.Items.Add(programName);
                }
            }

        }
    }
}

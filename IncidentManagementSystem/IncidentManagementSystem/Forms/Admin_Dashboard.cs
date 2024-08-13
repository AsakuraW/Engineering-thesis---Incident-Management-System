using IncidentManagementSystem.UserControls;
using SLRDbConnector;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IncidentManagementSystem.Forms
{
    public partial class Admin_Dashboard : Form
    {
        DbConnector db;
        private string userId;
        public Admin_Dashboard(string uid)
        {
            InitializeComponent();
            db = new DbConnector();
            button_branch.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_home_admin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_list_reports.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_requests.FlatAppearance.MouseDownBackColor = Color.Transparent;
            userId = uid;
        }

        private void addControls(UserControl uc)
        {
            main_panel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            main_panel.Controls.Add(uc);
            uc.BringToFront();
        }
        private void button_home_admin_Click(object sender, EventArgs e)
        {
            panel_choice.Height = button_home_admin.Height;
            panel_choice.Top = button_home_admin.Top;

            UC_admin_home uah = new UC_admin_home();
            addControls(uah);
        
        }

        private bool ifExistList()
        {
            string numbers_of_rows = db.getSingleValue("select COUNT(idTroubles) from Troubles", out numbers_of_rows, 0);
            if (Convert.ToInt32(numbers_of_rows) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button_list_reports_Click(object sender, EventArgs e)
        {
            panel_choice.Height = button_list_reports.Height;
            panel_choice.Top = button_list_reports.Top;
            if (ifExistList())
            {

                UC_admin_reports uar = new UC_admin_reports();
                addControls(uar);
            }
            else
            {
                MessageBox.Show("Aktualne brak zgłoszeń", "Pusto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void SaveSettingValue(string value)
        {
            string filePath = "setting.txt";
            File.WriteAllText(filePath, value);
        }


        private string ReadSettingValue()
        {
            string filePath = "setting.txt";
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            return string.Empty; 
        }



        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            UC_admin_home uah = new UC_admin_home();
            addControls(uah);
            string storedValue = ReadSettingValue();
            comboBoxHowManyDays.Text = storedValue;
            if(storedValue != "nie przypominaj") { 
            string count_of_row = db.getSingleValue("SELECT COUNT(*) FROM Troubles WHERE start_date < DATEADD(DAY, -"+storedValue+", GETDATE()) and Status_idStatus in (1,2);", out count_of_row, 0);
            string count_of_row_que = db.getSingleValue("SELECT COUNT(*) FROM Troubles WHERE start_date < DATEADD(DAY, -"+storedValue+", GETDATE()) and Status_idStatus in (1);", out count_of_row_que, 0);
            string count_of_row_realization = db.getSingleValue("SELECT COUNT(*) FROM Troubles WHERE start_date < DATEADD(DAY, -"+storedValue+", GETDATE()) and Status_idStatus in (2);", out count_of_row_realization, 0);
            
            if (!string.IsNullOrEmpty(storedValue))
            {
                if (Convert.ToInt32(count_of_row) != 0)
                {
                    MessageBox.Show("Sprawdź listę zgłoszonych incydentów! \n\n Zaległe zgłoszenia oczekujące: " + count_of_row_que + "\n Zaległe zgłoszenia w realizacji: " + count_of_row_realization, "Zaległe zgłoszenia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            }


        }

        private void button_branch_Click(object sender, EventArgs e)
        {
            panel_choice.Height = button_branch.Height;
            panel_choice.Top = button_branch.Top;
            UC_branch ub = new UC_branch(userId);
            addControls(ub);
            
        }

        private bool ifExistRequest()
        {
            string numbers_of_rows = db.getSingleValue("select COUNT(idRequest) from Request", out numbers_of_rows, 0);
            if (Convert.ToInt32(numbers_of_rows) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button_new_report_Click(object sender, EventArgs e)
        {
            panel_choice.Height = button_requests.Height;
            panel_choice.Top = button_requests.Top;

            if (ifExistRequest())
            {

                UC_request_list url = new UC_request_list();
                addControls(url);
            } else
            {
                MessageBox.Show("Aktualnie brak próśb", "Pusto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void comboBoxHowManyDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBoxHowManyDays.SelectedItem.ToString();
            SaveSettingValue(selectedValue);
        }
    }
}

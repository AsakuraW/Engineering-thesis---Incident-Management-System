using IncidentManagementSystem.UserControls;
using SLRDbConnector;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IncidentManagementSystem.Forms
{
    public partial class User_Dashboard : Form
    {
        DbConnector db;
        private string userId;
       
        public User_Dashboard(string id)
        {
            InitializeComponent();
            db = new DbConnector();
            userId = id;
            button_option.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_help.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_new_report.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_your_reports.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button_home.FlatAppearance.MouseDownBackColor = Color.Transparent;

        }

        private void button_new_report_Click(object sender, EventArgs e)
        {
            using(New_report nr = new New_report(userId)) 
            { 
                nr.ShowDialog();
                this.OnLoad(e);
            }
            panel_choice.Height = button_new_report.Height;
            panel_choice.Top = button_new_report.Top;
        }

        private void User_Dashboard_Load(object sender, EventArgs e)
        {
            //timer1.Start();
    
            UC_home uh = new UC_home(userId);
            addControls(uh);

        }

        private void addControls(UserControl uc)
        {
            main_panel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            main_panel.Controls.Add(uc);
            uc.BringToFront();
        }
        private void button_your_reports_Click(object sender, EventArgs e)
        {
            if (ifExist())
            {
                UC_your_reports uyr = new UC_your_reports(userId);
                addControls(uyr);
                
            }
            else
            {
                
            }
            
        }

        private bool ifExist()
        {
            string numbers_of_rows = db.getSingleValue("select COUNT(idTroubles) from Troubles where Users_idUsers=" + Convert.ToInt32(userId), out numbers_of_rows, 0);
            if(Convert.ToInt32(numbers_of_rows) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

   
      

        private void button_option_Click(object sender, EventArgs e)
        {

            UC_change_password ucp = new UC_change_password(userId);
            addControls(ucp);

            panel_choice.Height = button_option.Height;
            panel_choice.Top = button_option.Top;
        }

        private void button_your_reports_Click_1(object sender, EventArgs e)
        {
            if (ifExist())
            {
                UC_your_reports uyr = new UC_your_reports(userId);
                addControls(uyr);
            }
            else
            {
                MessageBox.Show("Aktualnie nie posiadasz żadnych złgoszeń", "Pusto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            panel_choice.Height = button_your_reports.Height;
            panel_choice.Top = button_your_reports.Top;
        }

        private void buton_home_Click(object sender, EventArgs e)
        {
            UC_home uh = new UC_home(userId);
            addControls(uh);

            panel_choice.Height = button_home.Height;
            panel_choice.Top = button_home.Top;
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("System zgłaczania incydentów ma na celu przyśpieszenie realizacji określonych zrządań/problemów." +
                "Dodaj zgłoszenie, a my przystąpimy do działania. Możesz śledzić status w aplikacji lub powiadomimy cię mailowo o zakończonej pracy.", "System zgłaszania incydentów", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

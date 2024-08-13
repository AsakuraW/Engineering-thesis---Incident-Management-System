using IncidentManagementSystem.Forms;
using SLRDbConnector;
using System;
using System.Windows.Forms;

namespace IncidentManagementSystem
{
   
    public partial class Login : Form
    {
       
        DbConnector db;
        public Login()
        {
            InitializeComponent();
           
            db = new DbConnector();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
           
            if (isFormValid())
            {
                if (LoginCheck())
                {
                    if(AdminCheck())
                    {
                        string userId = db.getSingleValue("Select idUsers from Users where email = '" + textBox_email.Text + "'", out userId, 0);
                        using (User_Dashboard ud = new User_Dashboard(userId))
                        {             
                            ud.ShowDialog();
                            this.Close();
                        }
                      

                    }
                    else
                    {
                        string userId = db.getSingleValue("Select idUsers from Users where email = '" + textBox_email.Text + "'", out userId, 0);

                        using (Admin_Dashboard ad = new Admin_Dashboard(userId))
                        {
                            ad.ShowDialog();
                            this.Close();
                        }
                    }

                }
               
            }
            
        }

        private bool AdminCheck()
        {
            string if_admin = db.getSingleValue("Select Role_idRole from Users where email = '" + textBox_email.Text + "'",out if_admin,0);
            
            if (if_admin != 1.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool LoginCheck()
        {
         
            string login = db.getSingleValue("select email from Users where email ='"+textBox_email.Text+"' and passwd = '"+textBox_pass.Text+"' ",out login,0);
            if (login == null)
            {
                MessageBox.Show("Podany login lub hasło jest nieprawidłowe","Nieprawidłowe dane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool isFormValid()
        {
            if (textBox_email.Text.ToString().Trim() == string.Empty || textBox_pass.Text.ToString().Trim()==string.Empty)
            {
                MessageBox.Show("Wypełnij wszystkie pola, aby się zalogować","Puste pola");
                return false;
            }
            else
            {
                return true;
            }
        }


        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass.Checked == true)
            {
                textBox_pass.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_pass.UseSystemPasswordChar = true;
            }
        }

        private void button_send_report_Click(object sender, EventArgs e)
        {
            using (Logout_request lr = new Logout_request())
            {
                lr.ShowDialog();
            }
        }
    }
}

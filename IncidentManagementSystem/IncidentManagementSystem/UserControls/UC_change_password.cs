using SLRDbConnector;
using System;
using System.Linq;
using System.Windows.Forms;

namespace IncidentManagementSystem.UserControls
{
    public partial class UC_change_password : UserControl
    {
        private string userId;
        DbConnector db;
        public UC_change_password(string id)
        {
            InitializeComponent();
            db = new DbConnector();
            userId = id;
        }

        private void button_send_report_Click(object sender, EventArgs e)
        {
            string able_to_change = db.getSingleValue("select able_to_change_passwd from Users where idUsers" + Convert.ToInt32(userId), out able_to_change, 0);

            if (able_to_change == "1") { 
            if (isValid())
            {
                if (ifPassCorrect())
                {
                    if(ValidPass())
                    {
                        if (textBox_new_pass.Text == textBox_new_pass_rep.Text) 
                        {
                            changePassword();
                        }
                        else
                        {
                            MessageBox.Show("Podano dwa różne, nowe hasła", "Niepasujące hasła", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hasło powinno składać się z: \n 1. Przynajmniej 1 wielkiej litery\n 2. Przynajmniej 1 małej litery \n 3. Przynajmniej 1 znaku specjalnego \n 4.Przynajmniej jednej liczby \n oraz minimum 8 znaków", "Walidacja hasłą", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            }else
            {
                MessageBox.Show("Aplikacja do zgłaszania incydentów jest ogólnodostępna dla każdej osoby prowadzącej zajęcia w tej sali.\n\n W razie potrzeby zmiany hasła skontaktuj się z nami w zakładce NOWE ZGŁOSZENIE, a my nadamy ci prawa do zmiany hasła", "Brak uprawnień", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePassword()
        {
            DialogResult dr = MessageBox.Show("Czy potwierdzasz zmiane hasła?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                db.performCRUD("update Users set passwd = '"+textBox_new_pass.Text+"' where idUsers = "+ Convert.ToInt32(userId));
                MessageBox.Show("Hasło zostało zmienione pomyślnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_new_pass.Text = "";
                textBox_new_pass_rep.Text = "";
                textBox_old_pass.Text = "";
            }
        }

        private bool ValidPass()
        {
            string password = textBox_new_pass.Text;
            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(c => !char.IsLetterOrDigit(c))) return true;
            else return false;

        }
        private bool ifPassCorrect()
        {
            string pass = db.getSingleValue("select passwd from Users where idUsers =" +Convert.ToInt32(userId), out pass, 0);
            if(pass == textBox_old_pass.Text) 
            {
                return true;
            }else
            {
                MessageBox.Show("Podano nieprawidłowe obecne hasło.", "Błędne hasło", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private bool isValid()
        {
            if (textBox_new_pass.Text.Trim() == string.Empty ||
                 textBox_new_pass_rep.Text.Trim() == string.Empty ||
                 textBox_old_pass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Wypełnij wszystkie pola, aby zmienić hasło", "Puste pola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

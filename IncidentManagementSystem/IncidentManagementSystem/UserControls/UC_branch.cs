using IncidentManagementSystem.Forms;
using SLRDbConnector;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace IncidentManagementSystem.UserControls
{
    public partial class UC_branch : UserControl
    {
        DbConnector db;
        private string userId;

        public UC_branch(string uid)
        {
            InitializeComponent();
            db = new DbConnector();
            userId = uid;
            

        }


        private void UC_branch_Load(object sender, EventArgs e)
        {
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;

            comboBox7.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox7.AutoCompleteSource = AutoCompleteSource.ListItems;


            db.FillCombobox("select email from Users where Role_idRole = 2", comboBox1);
            db.FillCombobox("select email from Users where Role_idRole = 2", comboBox2);
            db.FillCombobox("select name from Type", comboBox4);
            db.FillCombobox("select name from programs_for_checkboxs", comboBox5);
            db.FillCombobox("select email from Users", comboBox6);
            db.FillCombobox("select email from Users", comboBox7);


        }
        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private bool EmailValidation(string email)
        {
            if (textBox_email.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Pole z adresem e-mail nie może zostać puste", "Puste pole", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void button_passwd_reset_Click(object sender, EventArgs e)
        {
            if (EmailValidation(textBox_email.Text) )
            {
                if(comboBox1.SelectedItem != null) 
                {  
                DialogResult dr = MessageBox.Show("Czy na pewno zresetować hasło do konta: "+ comboBox1.SelectedItem.ToString()+"?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) { 
                    try
                    {
                        string new_password = GenerateRandomString(10);

                        // Tworzenie wiadomości e-mail
                        string fromEmail = "gracek05@op.pl";
                        string passwd = "Kornelia02";
                        string smtp = "smtp.poczta.onet.pl";
                        int port = 587;

                        string toEmail = textBox_email.Text;
                        string subject = "Nowe hasło ";
                        string body = "Witaj! <br><br> Twoje nowe hasło do konta o identyfikatorze: <i>"+comboBox1.Text+"</i> to:<br> <b>" + new_password + "</b>";



                        // Ustawienie adresu e-mail nadawcy
                        MailAddress fromAddress = new MailAddress(fromEmail);

                        // Tworzenie wiadomości e-mail
                        MailMessage message = new MailMessage();
                        message.From = fromAddress;
                        message.To.Add(toEmail);
                        message.Subject = subject;
                        message.IsBodyHtml = true;
                        message.Body = body;

                        // Konfiguracja klienta SMTP
                        using (var client = new SmtpClient(smtp, port))
                        {
                            client.EnableSsl = true;
                            client.Credentials = new System.Net.NetworkCredential(fromEmail, passwd);

                            // Wysłanie wiadomości
                            client.Send(message);
                            textBox_email.Text = "";
                            MessageBox.Show("Pomyślnie zresetowano hasło", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        db.performCRUD("update Users set passwd ='" + new_password + "' where email='" + toEmail + "'");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas wysyłania wiadomości: " + ex.Message);
                    }
                    }
                    
                }
            } 
        }

        private void buttonAdd_priv_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Czy na pewno nadać uprawnienia zmiany hasła do konta: " + comboBox2.SelectedItem.ToString() + "?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Pomyślnie nadano uprawnienia", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.performCRUD("update Users set able_to_change_passwd = 1 where email = '" + comboBox2.Text+"'");

                }
            }
            else
            {
                MessageBox.Show("Wybierz identyfikator sali do nadania uprawnień", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_priv_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Czy na pewno odebrać uprawnienia zmiany hasła do konta: " + comboBox2.SelectedItem.ToString() + "?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Pomyślnie odebrano uprawnienia", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.performCRUD("update Users set able_to_change_passwd = 0 where email = '" + comboBox2.Text + "'");

                }
            }
            else
            {
                MessageBox.Show("Wybierz identyfikator sali do odebrania uprawnień", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePassword()
        {
            DialogResult dr = MessageBox.Show("Czy potwierdzasz zmiane hasła?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                db.performCRUD("update Users set passwd = '" + textBox_new_pass.Text + "' where idUsers = " + Convert.ToInt32(userId));
                MessageBox.Show("Hasło zostało zmienione pomyślnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_new_pass.Text = "";
                textBox_new_pass_rep.Text = "";
                textBoxOld_pass.Text = "";
            }
        }

        private bool isValid()
        {
            if (textBox_new_pass.Text.Trim() == string.Empty ||
                 textBox_new_pass_rep.Text.Trim() == string.Empty ||
                 textBoxOld_pass.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Wypełnij wszystkie pola, aby zmienić hasło", "Puste pola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
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
            string pass = db.getSingleValue("select passwd from Users where idUsers =" + Convert.ToInt32(userId), out pass, 0);
            if (pass == textBoxOld_pass.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Podano nieprawidłowe obecne hasło.", "Błędne hasło", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void buttonChange_admin_pass_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                if (ifPassCorrect())
                {
                    if (ValidPass())
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
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            if(textBoxAddCategory.Text.Trim() != string.Empty)
            {
                string categoryName = db.getSingleValue("select name from Type where name = '" + textBoxAddCategory.Text + "'", out categoryName, 0);

                if(textBoxAddCategory.Text.Trim() != categoryName) { 
                    DialogResult dr = MessageBox.Show("Czy na pewno dodać nową kategorie?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Pomyślnie dodano nową kategorie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.performCRUD("insert into Type values ('" + textBoxAddCategory.Text + "')");
                        comboBox4.Items.Add(textBoxAddCategory.Text);
                        comboBox4.Refresh();
                        textBoxAddCategory.Text = "";
                   
                    }
                }
                else MessageBox.Show("Podana kategoria już widnieje na liście", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelCategory_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Czy na pewno ukryć podaną kategorie?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Pomyślnie ukryto kategorie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.performCRUD("update Type set is_hidden = 1 where name = '" + comboBox4.Text + "'");
                    comboBox4.Refresh();
                }
            }
        }

        private void buttonDel_program_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Czy na pewno usunąć program z listy?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Pomyślnie usunięto", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.performCRUD("delete from programs_for_checkboxs where name = '" + comboBox5.Text + "'");
                    comboBox5.Items.Remove(comboBox5.SelectedItem); 
                    comboBox5.SelectedItem = null;
                    comboBox5.Refresh();


                }
            }
        }

        private void buttonAdd_Program_Click(object sender, EventArgs e)
        {
            if (textBoxName_program.Text.Trim() != string.Empty)
            {
                string programName = db.getSingleValue("select name from programs_for_checkboxs where name = '" + textBoxName_program.Text + "'", out programName, 0);

                if(textBoxName_program.Text.Trim() != programName) { 
                    DialogResult dr = MessageBox.Show("Czy na pewno dodać program do listy?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Pomyślnie dodano nowy program do listy", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.performCRUD("insert into programs_for_checkboxs values ('" + textBoxName_program.Text + "')");
                        comboBox5.Items.Add(textBoxName_program.Text);
                        comboBox5.Refresh();
                        textBoxName_program.Text = "";

                    }
                }else MessageBox.Show("Podany program już widnieje na liście", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = tabControl1.PointToClient(new Point(e.X, e.Y));
            int index = tabControl1.TabCount - 1;
            for (int i = 0; i < tabControl1.TabCount; i++)
            {
                if (tabControl1.GetTabRect(i).Contains(clientPoint))
                {
                    index = i;
                    break;
                }
            }
            TabPage tabPage = (TabPage)e.Data.GetData(typeof(TabPage));
            tabControl1.TabPages.Remove(tabPage);
            tabControl1.TabPages.Insert(index, tabPage);
            tabControl1.SelectedTab = tabPage;
        }


        private Point mouseDownLocation;
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }


        private void tabControl1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tabControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int index = tabControl1.SelectedIndex;
                TabPage tabPage = tabControl1.TabPages[index];
                tabControl1.DoDragDrop(tabPage, DragDropEffects.All);
            }
        }

        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            if(comboBox7.SelectedItem != null && textBoxNew_name.Text.Trim() != string.Empty)
            {
                DialogResult dr = MessageBox.Show("Czy na pewno zmienić identyfikator sali?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Pomyślnie ustawiono nowy identyfikator", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.performCRUD("update Users set email = '" + textBoxNew_name.Text + "' where email ='" + comboBox7.Text + "'");
                    comboBox7.Items.Remove(comboBox7.SelectedItem);
                    comboBox7.Items.Add(textBoxNew_name.Text);
                    comboBox7.SelectedItem = textBoxNew_name.Text;
                    comboBox7.Refresh();
                    textBoxNew_name.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola, aby zmienić identyfikator sali", "Puste pola", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {
            if (comboBox6.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Potwierdzając usunięcie konta spowodujesz nieodwracalne zmiany.\n\nZostanie usuniętę konto o identyfikatorze sali: "+comboBox6.Text+" oraz WSZYSTKIE informacje o dotychczasowych zgłoszeniach.\n\nCzy chcesz kontynuować?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Pomyślnie usunięto konto", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.performCRUD("DELETE FROM Troubles WHERE Users_idUsers = (SELECT idUsers FROM Users WHERE email = '" + comboBox6.Text + "')");
                    db.performCRUD("DELETE FROM Users WHERE email = '" + comboBox6.Text + "'");

                    comboBox6.Items.Remove(comboBox6.SelectedItem);
                    comboBox7.Items.Remove(comboBox6.SelectedItem);
                    comboBox7.Refresh();
                    comboBox6.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Wybierz identyfikator sali, aby usunąć konto", "Puste pola", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (textBoxNewNameAdd.Text.Trim() != string.Empty)
            {
                string name = db.getSingleValue("select email from Users where email = '" +textBoxNewNameAdd.Text +"'", out name, 0);

                if(textBoxNewNameAdd.Text.Trim() != name) 
                { 

                    int role;
                    string able_to_chng_pass = "";

                    if (checkBoxIfAdmin.Checked) role = 1; else role = 2;
                    if (checkBoxIfAble.Checked) able_to_chng_pass = "1"; else able_to_chng_pass= "0";

                    DialogResult dr = MessageBox.Show("Czy na pewno dodać nowe konto o identyfikatorze: " + textBoxNewNameAdd.Text+"?\n\n Hasłem do konta będzie bieżący identyfikator sali tj.: " + textBoxNewNameAdd.Text, "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        MessageBox.Show("Pomyślnie dodano nowe konto", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.performCRUD("insert into Users (email,passwd,Role_idRole,able_to_change_passwd) values ('" + textBoxNewNameAdd.Text+"','"+ textBoxNewNameAdd.Text + "',"+role+",'"+able_to_chng_pass+"')");
                        comboBox7.Items.Add(textBoxNewNameAdd.Text);
                        comboBox6.Items.Add(textBoxNewNameAdd.Text);
                        comboBox7.Refresh();
                        comboBox6.Refresh();
                        textBoxNewNameAdd.Text = "";
                   
                    }
                    

                }
                else MessageBox.Show("Istnienie już konto o podanym identyfikatorze", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Wybierz identyfikator sali, aby usunąć konto", "Puste pola", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSeeCategory_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Czy na pewno odkryć podaną kategorie?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MessageBox.Show("Pomyślnie odkryto kategorie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.performCRUD("update Type set is_hidden = 0 where name = '" + comboBox4.Text + "'");
                    comboBox4.Refresh();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string categoryId = db.getSingleValue("select idType from Type where name = '" + comboBox4.Text+"'", out categoryId, 0);

            using (Edit_category ec = new Edit_category(categoryId))
            {
                ec.ShowDialog();
            }
        }
    }
}

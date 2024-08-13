using SLRDbConnector;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace IncidentManagementSystem.Forms
{



    public partial class Send_to_realization : Form
    {
 

        DbConnector db;
        private string troubleId;

        public Send_to_realization(string tid)
        {
            InitializeComponent();
            troubleId = tid;
            db = new DbConnector();


        }

        private void Send_to_realization_Load(object sender, EventArgs e)
        {
            label1.Text = troubleId;
            db.FillCombobox("select email from emails_for_realization", comboBoxListOfMails);
            db.FillCombobox("select email from emails_for_realization", comboBoxReplic);
        }
 
        private void button_send_Click(object sender, EventArgs e)
        {
          if(comboBoxListOfMails.SelectedItem != null) 
          {
                string buildingStreet = "";
            string mail = db.getSingleValue("select u.email from Troubles t join Users u on t.Users_idUsers = u.idUsers where idTroubles = " + Convert.ToInt32(troubleId), out mail, 0);
            string topic = db.getSingleValue("select subiect from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out topic, 0);
            string desc = db.getSingleValue("select description from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out desc, 0);
            string place = db.getSingleValue("select place from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out place, 0);
            string type = db.getSingleValue("select ty.name from Troubles t join Type ty on t.Type_idType = ty.idType where idTroubles = " + Convert.ToInt32(troubleId), out type, 0);
            string building = db.getSingleValue("select building from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out building, 0);
            if (Convert.ToInt32(building) == 1) buildingStreet = "Al. Grunwaldzka 137";
            if (Convert.ToInt32(building) == 2) buildingStreet = "ul. Czerniakowska 22";
            if (Convert.ToInt32(building) == 3) buildingStreet = "ul. Wojska Polskiego 1";
            try
            {
                // Tworzenie wiadomości e-mail
                string fromEmail = "gracek05@op.pl";
                string passwd = "Kornelia02";
                string smtp = "smtp.poczta.onet.pl";
                int port = 587;

                string toEmail = comboBoxListOfMails.SelectedItem.ToString();
                string subject = "Realizacja zgłoszenia ID "+troubleId;
                string body = "<b>Identyfikator zgłoszenia:</b> "+mail+ "<br><br><b>Temat:</b> " + topic+ " <br><b>Rodzaj: </b>"+type+"<br><b>Sala:</b> " + place+"<b><br>Budynek:</b> "+buildingStreet+"<br><br><b>Treść:<br></b> "+desc;

              

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
                    MessageBox.Show("Wiadomość została wysłana.","Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                   db.performCRUD("update Troubles set Status_idStatus = 2, Who = '"+comboBoxListOfMails.SelectedItem.ToString()+"' where idTroubles = " + Convert.ToInt32(troubleId));
                    this.Dispose();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas wysyłania wiadomości: " + ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Wybierz osobę do rowiązania zgłoszenia", "Brak adresu e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
       
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno usunąć podany adres e-mail?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DeleteComboBoxValuesToFile();
                MessageBox.Show("Pomyślnie usunięto adres e-mail", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

           
                string valueToAdd = textBoxMail.Text; // pobierz wartość z TextBoxa
                string valueToAddTwo = textBoxMailTwo.Text;
            if (valueToAdd.Trim() != string.Empty && valueToAddTwo.Trim() != string.Empty)
            { 
                if (!comboBoxListOfMails.Items.Contains(valueToAdd)) // sprawdź, czy wartość już istnieje w ComboBoxie
                    {
                    
                            if(valueToAdd == valueToAddTwo) 
                            {
                        
                                if (IsValidEmail(valueToAdd))
                                {
                                DialogResult dr = MessageBox.Show("Czy na pewno dodać podany adres e-mail?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (dr == DialogResult.Yes)
                                    {
                                        
                                        MessageBox.Show("Pomyślnie dodano adres e-mail", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        db.performCRUD("insert into emails_for_realization (email) VALUES ('"+valueToAdd+"')");

                                        textBoxMail.Text = "";
                                        textBoxMailTwo.Text = "";
                                        

                            }
                                }
                                else
                                {
                                    MessageBox.Show("Podano niepoprawną składnie adresu e-mail", "Niepoprawna składnia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Podane adresy e-mail różnią się od siebie", "Różne adresy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                    else
                    {
                        MessageBox.Show("Podany adres e-mail jest już na liście", "Dublowanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                MessageBox.Show("Żadne pole nie może być puste", "Puste pola", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            this.Close();
        }

      


        private void DeleteComboBoxValuesToFile()
        {
            if (comboBoxReplic.SelectedItem != null) // sprawdź, czy wybrano element
            {
                db.performCRUD("delete from emails_for_realization where email = '"+comboBoxReplic.Text+"'");
                this.Close();

            }
            else
            {
                MessageBox.Show("Nie wybrano wartości do usunięcia", "Brak wyboru", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


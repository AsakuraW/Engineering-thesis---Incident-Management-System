using SLRDbConnector;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace IncidentManagementSystem.Forms
{
    public partial class Request_realization : Form
    {
        DbConnector db;
        private string requestId;
        public Request_realization(string rid)
        {
            InitializeComponent();
            db = new DbConnector();
            requestId = rid;
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno przekazać realizację prośby?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string buildingStreet = "";
                
                string mail = db.getSingleValue("select email from Request where idRequest = " + Convert.ToInt32(requestId), out mail, 0);
                string dateStart = db.getSingleValue("select date_start from Request where idRequest = " + Convert.ToInt32(requestId), out dateStart, 0);
                string dateEnd = db.getSingleValue("select date_end from Request where idRequest = " + Convert.ToInt32(requestId), out dateEnd, 0);
                string place = db.getSingleValue("select place from Request where idRequest = " + Convert.ToInt32(requestId), out place, 0);
                string building = db.getSingleValue("select building from Request where idRequest = " + Convert.ToInt32(requestId), out building, 0);
                if (Convert.ToInt32(building) == 1) buildingStreet = "Al. Grunwaldzka 137";
                if (Convert.ToInt32(building) == 2) buildingStreet = "ul. Czerniakowska 22";
                if (Convert.ToInt32(building) == 3) buildingStreet = "ul. Wojska Polskiego 1";
                string programs = db.getSingleValue(" select programs from Request where idRequest = " + Convert.ToInt32(requestId), out programs, 0);

                try
                {
                    // Tworzenie wiadomości e-mail
                    string fromEmail = "gracek05@op.pl";
                    string passwd = "Kornelia02";
                    string smtp = "smtp.poczta.onet.pl";
                    int port = 587;

                    string toEmail = comboBoxListOfMails.Text;
                    string subject = "Realizacja prośby przygotowania sali o ID " + requestId;
                    string body = "<b>Zgłaszający: </b>"+mail+"<br><br><b>Data zgłoszenia:</b> <i>" + dateStart + "</i><br> <b>Planowana data: </b><i>"+dateEnd+"</i> <br><br> <b>Budynek:</b> " + buildingStreet + "<br><b>Sala:</b> " + place+"<br><b>Wybrane programy: </b><i>"+programs+"</i>";



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
                        MessageBox.Show("Pomyślnie przekazano", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.OnLoad(e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas wysyłania wiadomości: " + ex.Message);
                }
                this.Dispose();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Request_realization_Load(object sender, EventArgs e)
        {
            label1.Text = requestId;
            db.FillCombobox("select email from emails_for_realization", comboBoxListOfMails);
        }
    }
}

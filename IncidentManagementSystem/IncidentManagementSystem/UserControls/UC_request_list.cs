using IncidentManagementSystem.Forms;
using SLRDbConnector;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace IncidentManagementSystem.UserControls
{
   
    public partial class UC_request_list : UserControl
    {
        DbConnector db;
        private string requestId;

        public UC_request_list()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void UC_request_list_Load(object sender, EventArgs e)
        {
            db.fillDataGridView("select idRequest as ID, email as 'E-mail', date_start as 'Data złożenia', place as Sala, date_end as 'Data planowana', programs as Programy from Request order by date_end asc", dataGridView1);
            button_done.Enabled = false;
            button_details.Enabled = false;
            buttonSendToRealization.Enabled = false;
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            if (comboBox_searchBy.SelectedItem.Equals("ID"))
            {
                query = "Select idRequest as ID, email as 'E-mail', date_start as 'Data złożenia', place as Sala, date_end as 'Data planowana', programs as Programy from Request where idRequest = " + textBox_search.Text+ " order by date_end asc ";
            }
            if (comboBox_searchBy.SelectedItem.Equals("E-mail"))
            {
                query = "Select idRequest as ID, email as 'E-mail', date_start as 'Data złożenia', place as Sala, date_end as 'Data planowana', programs as Programy from Request where email LIKE '%" + textBox_search.Text + "%' order by date_end asc ";

            }
            if (comboBox_searchBy.SelectedItem.Equals("Data złożenia"))
            {
                query = "Select idRequest as ID, email as 'E-mail', date_start as 'Data złożenia', place as Sala, date_end as 'Data planowana', programs as Programy from Request where date_start LIKE '%" + textBox_search.Text + "%' order by date_end asc ";

            }
            if (comboBox_searchBy.SelectedItem.Equals("Data planowana"))
            {
                query = "Select idRequest as ID, email as 'E-mail', date_start as 'Data złożenia', place as Sala, date_end as 'Data planowana', programs as Programy from Request where date_end LIKE '%" + textBox_search.Text + "%' order by date_end asc ";

            }
            db.fillDataGridView(query, dataGridView1);

            if (textBox_search.Text == "")
            {
                this.OnLoad(e);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button_details.Enabled = true;
            button_done.Enabled=true;
            buttonSendToRealization.Enabled = true; 
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                requestId = row.Cells[0].Value.ToString();
            }
        }

        private void button_details_Click(object sender, EventArgs e)
        {
            if (!requestId.Equals(String.Empty))
            {

                using (Admin_request_details ard = new Admin_request_details(requestId))
                {
                    ard.ShowDialog();
                }
            }
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy na pewno zakończyć realizację prośby?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {


                string mail = db.getSingleValue("select email from Request where idRequest = "+Convert.ToInt32(requestId), out mail, 0);
                string programs = db.getSingleValue(" select programs from Request where idRequest = " + Convert.ToInt32(requestId), out programs, 0);
                string data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                try
                {
                    // Tworzenie wiadomości e-mail
                    string fromEmail = "gracek05@op.pl";
                    string passwd = "Kornelia02";
                    string smtp = "smtp.poczta.onet.pl";
                    int port = 587;

                    string toEmail = mail;
                    string subject = "Zakończenie realizacji prośby o ID " + requestId;
                    string body = "<b>Witaj!</b><br><br>realizacja twojej prośby na: <i>"+programs+"</i> została właśnie zakończona. <br><br> <i>data zakończenia:" + data + " </i><br><br> Miłego dnia!";



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
                        MessageBox.Show("Pomyślnie zakończono", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  db.performCRUD("delete from Request where idRequest = " + requestId);
                    this.OnLoad(e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas wysyłania wiadomości: " + ex.Message);
                }
            }
        }

        private void buttonSendToRealization_Click(object sender, EventArgs e)
        {
            if (!requestId.Equals(String.Empty))
            {

                using (Request_realization rr = new Request_realization(requestId))
                {
                    rr.ShowDialog();
                }
            }
        }
    }
}

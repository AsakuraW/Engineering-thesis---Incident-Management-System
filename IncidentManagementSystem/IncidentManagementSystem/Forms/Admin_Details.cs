using SLRDbConnector;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IncidentManagementSystem.Forms
{
    public partial class Admin_Details : Form
    {
        DbConnector db;
        private string troubleId;
        public Admin_Details(string tid)
        {
            InitializeComponent();
            db = new DbConnector();
            troubleId = tid;
            buttonStatus.TabStop = false;
            buttonStatus.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonStatus.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void Admin_Details_Load(object sender, EventArgs e)
        {
            textBoxID.Text = troubleId;

            string mail = db.getSingleValue("select u.email from Troubles t join Users u on t.Users_idUsers = u.idUsers where idTroubles = " + Convert.ToInt32(troubleId), out mail, 0);
            textBoxMail.Text = mail;

            string type = db.getSingleValue("select ty.name from Troubles t join Type ty on t.Type_idType = ty.idType where idTroubles = " + Convert.ToInt32(troubleId), out type, 0);
            textBoxType.Text = type;

            string statusCheck = db.getSingleValue("select Status_idStatus from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out statusCheck, 0);
            string status = db.getSingleValue("select s.name from Troubles t join Status s on t.Status_idStatus = s.idStatus where idTroubles = " + Convert.ToInt32(troubleId), out status, 0);
            if (Convert.ToInt32(statusCheck) == 2) buttonStatus.ForeColor = Color.Orange;
            if (Convert.ToInt32(statusCheck) == 3) buttonStatus.ForeColor = Color.Green;
            buttonStatus.Text = status;

          

            string description = db.getSingleValue("select description from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out description, 0);
            textBox_description.Text = description;

            string title = db.getSingleValue("select subiect from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out title, 0);
            textBoxTitle.Text = title;

            string place = db.getSingleValue("SELECT SUBSTRING(email, 4, 3) as place FROM users u left join Troubles t on u.idUsers=t.Users_idUsers where t.idTroubles= " + Convert.ToInt32(troubleId), out place, 0);
            textBoxPlace.Text = place;

            string building = db.getSingleValue("SELECT SUBSTRING(email, 2, 1) AS building FROM users u left join Troubles t on u.idUsers=t.Users_idUsers where t.idTroubles= " + Convert.ToInt32(troubleId), out building, 0);
            if (Convert.ToInt32(building) == 1) textBoxBuilding.Text = "Al. Grunwaldzka 137";
            if (Convert.ToInt32(building) == 2) textBoxBuilding.Text = "ul. Czerniakowska 22";
            if (Convert.ToInt32(building) == 3) textBoxBuilding.Text = "ul. Wojska Polskiego 1";


            string startDate = db.getSingleValue("select start_date from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out startDate, 0);
            textBoxDataStart.Text = startDate;

            string endDate = db.getSingleValue("select end_date from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out endDate, 0);
            if (endDate != "")
            {
                textBoxDataStop.Text = endDate;
            }
            else
            {
                textBoxDataStop.Text = "Postaramy się rozwiązać twój problem jak najszybciej! ";
            }

            string who = db.getSingleValue("select who from Troubles where idTroubles = " + Convert.ToInt32(troubleId), out who, 0);
            if (who != "")
            {
                textBox_who.Text = who;
            }
            else
            {
                textBox_who.Text = "Twój problem wciąż czeka na przydzielenie odpowiedniej osoby";
            }
        }
    }
}

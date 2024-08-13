using SLRDbConnector;
using System;
using System.Windows.Forms;

namespace IncidentManagementSystem.Forms
{
    public partial class Admin_request_details : Form
    {
        DbConnector db;
        private string requestId;
        public Admin_request_details(string rid)
        {
            InitializeComponent();
            db = new DbConnector();
            requestId = rid;
      
        }

        private void Admin_request_details_Load(object sender, EventArgs e)
        {
            textBoxID.Text = requestId;

            string mail = db.getSingleValue(" select email from Request where idRequest = "+Convert.ToInt32(requestId), out mail, 0);
            textBoxWho.Text = mail;

            string dataStart = db.getSingleValue(" select date_start from Request where idRequest = " + Convert.ToInt32(requestId), out dataStart, 0);
            textBoxDataStart.Text = dataStart;

            string dataEnd = db.getSingleValue(" select date_end from Request where idRequest = " + Convert.ToInt32(requestId), out dataEnd, 0);
            textBoxDataEnd.Text = dataEnd;

            string place = db.getSingleValue(" select place from Request where idRequest = " + Convert.ToInt32(requestId), out place, 0);
            textBoxPlace.Text = place;

            string building = db.getSingleValue(" select building from Request where idRequest = " + Convert.ToInt32(requestId), out dataEnd, 0);
            if (Convert.ToInt32(building) == 1) textBoxBuilding.Text = "Al. Grunwaldzka 137";
            if (Convert.ToInt32(building) == 2) textBoxBuilding.Text = "ul. Czerniakowska 22";
            if (Convert.ToInt32(building) == 3) textBoxBuilding.Text = "ul. Wojska Polskiego 1";

            string programs = db.getSingleValue(" select programs from Request where idRequest = " + Convert.ToInt32(requestId), out programs, 0);

            string[] programList = programs.Split(',');
            foreach (string program in programList)
            {
                listBox1.Items.Add(program.Trim());
            }


        }
    }
}

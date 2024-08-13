using SLRDbConnector;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IncidentManagementSystem.UserControls
{
    public partial class UC_home : UserControl
    {
       
        DbConnector db;
        private string userId;
 

        public UC_home(string id)
        {
            InitializeComponent();
            db = new DbConnector();
            userId = id;
          
        }

        void FillChart()
        {

            string row_count = db.getSingleValue("select COUNT(idTroubles) from Troubles", out row_count, 0);
            int interwal = (int)Math.Ceiling((double)Convert.ToDouble(row_count) / 10);
            int currentYear = DateTime.Now.Year;

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = interwal;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Wyłączenie linii pomocniczych dla wartości głównych
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            Series series = chart1.Series.Add("Liczba zgłoszeń w miesiącu");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.SmartLabelStyle.Enabled = true;
            series.SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Top;
            series.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;

            for (int i = 1; i <= 12; i++)
            {
               
             
                string count_of_requests = db.getSingleValue("select COUNT(idTroubles) from Troubles where Users_idUsers=" + Convert.ToInt32(userId) + "and MONTH(start_date) = " + i + "AND YEAR(start_date) = " + Convert.ToInt32(DateTime.Now.Year), out count_of_requests, 0);
                series.Points.AddXY(new DateTime(currentYear, i, 1).ToString("MMM"), count_of_requests);
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            }
        }

        void FillLabels()
        {
            buttonStatus.TabStop = false;
            buttonStatus.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonStatus.FlatAppearance.MouseDownBackColor = Color.Transparent;

            string count_of_active_repo = db.getSingleValue("select  count(idTroubles) from Troubles where Users_idUsers=" + Convert.ToInt32(userId)+" AND Status_idStatus in (1,2)", out count_of_active_repo, 0);
            string count_of_done_repo = db.getSingleValue("select count(idTroubles) from Troubles where Users_idUsers=" + Convert.ToInt32(userId)+" AND Status_idStatus = 3", out count_of_done_repo, 0);
            string all_repo = db.getSingleValue("select count(idTroubles) from Troubles where Users_idUsers=" + Convert.ToInt32(userId), out all_repo, 0);
           
            if (Convert.ToInt32(all_repo) != 0)
            {
                label_info.Visible = false;
                panel_info.Visible = true;
            }
            else 
            { 
                label_info.Visible = true; 
                panel_info.Visible = false;
            }


            label_active_reports.Text = count_of_active_repo;
            label_done_reports.Text = count_of_done_repo;

            string title = db.getSingleValue("select TOP 1 subiect from Troubles where Users_idUsers=" + Convert.ToInt32(userId)+" order by start_date desc", out title, 0);
            textBoxTitle.Text = title;
            string startDate = db.getSingleValue("select TOP 1 start_date from Troubles where Users_idUsers=" + Convert.ToInt32(userId) + " order by start_date desc ", out startDate, 0);
            textBoxDataStart.Text = startDate;
            string description = db.getSingleValue("select TOP 1 description from Troubles where Users_idUsers=" + Convert.ToInt32(userId) + " order by start_date desc ", out description, 0);
            textBox_description.Text = description;

            string statusCheck = db.getSingleValue("select TOP 1 Status_idStatus from Troubles where Users_idUsers=" + Convert.ToInt32(userId) + " order by start_date desc ", out statusCheck, 0);
            string status = db.getSingleValue("select TOP 1 s.name from Troubles t join Status s on t.Status_idStatus = s.idStatus where t.Users_idUsers=" + Convert.ToInt32(userId) + " order by start_date desc ", out status, 0);
            if (Convert.ToInt32(statusCheck) == 2) buttonStatus.ForeColor = Color.Orange;
            if (Convert.ToInt32(statusCheck) == 3) buttonStatus.ForeColor = Color.Green;
            buttonStatus.Text = status;
        }

        private void UC_home_Load(object sender, EventArgs e)
        {
            FillChart();
            FillLabels();
        }

     
    }
}

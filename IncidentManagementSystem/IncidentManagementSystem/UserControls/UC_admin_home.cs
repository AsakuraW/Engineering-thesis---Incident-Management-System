using SLRDbConnector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IncidentManagementSystem.UserControls
{
    public partial class UC_admin_home : UserControl
    {
        DbConnector db;

        public UC_admin_home()
        {
            InitializeComponent();
            db = new DbConnector();
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

            Series series3 = chart1.Series.Add("Liczba zgłoszeń w kolejce");
            series3.ChartType = SeriesChartType.Column;
            series3.IsValueShownAsLabel = true;
            series3.SmartLabelStyle.Enabled = true;
            series3.SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Top;
            series3.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
            series3.Color = Color.Red;

            Series series2 = chart1.Series.Add("Zgłoszenia w realizacji");
            series2.ChartType = SeriesChartType.Column;
            series2.IsValueShownAsLabel = true;
            series2.SmartLabelStyle.Enabled = true;
            series2.SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Top;
            series2.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
            series2.Color = Color.Orange;

            Series series = chart1.Series.Add("Liczba wszystkich zgłoszeń w miesiącu");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.SmartLabelStyle.Enabled = true;
            series.SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Top;
            series.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;

        

            for (int i = 1; i <= 12; i++)
            {
                string count_of_que_requests = db.getSingleValue("select COUNT(idTroubles) from Troubles where MONTH(start_date) = " + i + "AND YEAR(start_date) = " + Convert.ToInt32(DateTime.Now.Year) + "AND Status_idStatus = 1 ", out count_of_que_requests, 0);
                series3.Points.AddXY(new DateTime(currentYear, i, 1).ToString("MMM"), count_of_que_requests);


                string count_of_active_requests = db.getSingleValue("select COUNT(idTroubles) from Troubles where MONTH(start_date) = " + i + "AND YEAR(start_date) = " + Convert.ToInt32(DateTime.Now.Year) + "AND Status_idStatus = 2", out count_of_active_requests, 0);
                series2.Points.AddXY(new DateTime(currentYear, i, 1).ToString("MMM"), count_of_active_requests);

                string count_of_requests = db.getSingleValue("select COUNT(idTroubles) from Troubles where MONTH(start_date) = " + i + "AND YEAR(start_date) = " + Convert.ToInt32(DateTime.Now.Year), out count_of_requests, 0);
                series.Points.AddXY(new DateTime(currentYear, i, 1).ToString("MMM"), count_of_requests);

                

                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            }
           
        }

        void FillChart2()
        {
            string row_count = db.getSingleValue("select COUNT(idTroubles) from Troubles", out row_count, 0);
            int interwal = (int)Math.Ceiling((double)Convert.ToDouble(row_count) / 10);
            chart2.Series.Clear();
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisY.Interval = interwal;

            chart2.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Wyłączenie linii pomocniczych dla wartości głównych
            chart2.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            Series series = chart2.Series.Add("Liczba aktywnych zgłoszeń przypadajaca na salę");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.SmartLabelStyle.Enabled = true;
            series.SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Top;
            series.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;

            List<string> list_of_places = new List<string>();

            string count_of_all_fields = db.getSingleValue("select COUNT(Distinct place) from Troubles ", out count_of_all_fields, 0);

            string places = db.GetSingleValueByArray("select Distinct place from Troubles where Status_idStatus in (1,2)", out list_of_places, 0);

            foreach (string place in list_of_places)
            {
                string count_of_reports_by_place = db.getSingleValue($"select COUNT(idTroubles) from Troubles where place='{place}' AND Status_idStatus in (1,2)", out count_of_reports_by_place, 0);
                series.Points.AddXY(place, Convert.ToInt32(count_of_reports_by_place));
            }

            chart2.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }

        void FillChart3()
        {
            string row_count = db.getSingleValue("select COUNT(idTroubles) from Troubles", out row_count, 0);
            int interwal = (int)Math.Ceiling((double)Convert.ToDouble(row_count) / 10);
            chart3.Series.Clear();
            chart3.ChartAreas[0].AxisX.Interval = 1;
            chart3.ChartAreas[0].AxisY.Interval = interwal;
            chart3.ChartAreas[0].AxisY.MajorGrid.Enabled = false; // Wyłączenie linii pomocniczych dla wartości głównych
            chart3.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            Series series = chart3.Series.Add("Liczba aktywnych zgłoszeń przypadajaca na budynek");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            series.SmartLabelStyle.Enabled = true;
            series.SmartLabelStyle.MovingDirection = LabelAlignmentStyles.Top;
            series.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;

            List<string> list_of_building = new List<string>();
            List<KeyValuePair<string, string>> buildingList = new List<KeyValuePair<string, string>>();

            string count_of_all_fields = db.getSingleValue("select COUNT(Distinct building) from Troubles ", out count_of_all_fields, 0);

            string building = db.GetSingleValueByArray("select Distinct building from Troubles where Status_idStatus in (1,2)", out list_of_building, 0);

            foreach (string b in list_of_building)
            {
                string name = "";
                if (b == "1")
                {
                    name = "Al. Grunwaldzka 137";
                }
                if (b == "2")
                {
                    name = "ul. Czerniakowska 22";
                }
                if (b == "3")
                {
                    name = "ul. Wojska Polskiego 1";
                }
                // Dodaj parę wartości do listy
                buildingList.Add(new KeyValuePair<string, string>(b, name));
            }


            foreach (KeyValuePair<string, string> buildings in buildingList)
            {
                string count_of_reports_by_place = db.getSingleValue($"select COUNT(idTroubles) from Troubles where building='{buildings.Key}' AND Status_idStatus in (1,2)", out count_of_reports_by_place, 0);
                series.Points.AddXY(buildings.Value, Convert.ToInt32(count_of_reports_by_place));
            }

            chart3.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
        }

        void FillLabels()
        {
           

            string count_of_que_repo = db.getSingleValue("select  COUNT(idTroubles) from Troubles where Status_idStatus = 1", out count_of_que_repo, 0);
            string count_of_active_repo = db.getSingleValue("select  COUNT(idTroubles) from Troubles where Status_idStatus = 2", out count_of_active_repo, 0);
            string count_of_que_users = db.getSingleValue("select  COUNT(DISTINCT Users_idUsers) from Troubles where Status_idStatus = 1", out count_of_que_users, 0);

            if (Convert.ToInt32(count_of_que_repo) != 0)
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
            label_que_reports.Text = count_of_que_repo;
            label_que_users.Text = count_of_que_users;

            string title = db.getSingleValue("select TOP 1 subiect from Troubles where Status_idStatus = 1 order by start_date asc", out title, 0);
            textBoxTitle.Text = title;
            string startDate = db.getSingleValue("select TOP 1 start_date from Troubles where Status_idStatus = 1 order by start_date asc", out startDate, 0);
            textBoxDataStart.Text = startDate;
            string description = db.getSingleValue("select TOP 1 description from Troubles where Status_idStatus = 1 order by start_date asc", out description, 0);
            textBox_description.Text = description;
            string who = db.getSingleValue("select top 1 u.email from Troubles t join  Users u on t.Users_idUsers = u.idUsers where Status_idStatus = 1 order by start_date asc ", out description, 0);
            textBoxWho.Text = who;


   
        }
        private void UC_admin_home_Load(object sender, EventArgs e)
        {
            FillChart();
            FillLabels();
            FillChart2();
            FillChart3();
        }
    }
}

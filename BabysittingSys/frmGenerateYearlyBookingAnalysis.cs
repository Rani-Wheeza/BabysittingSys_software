using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BabysittingSys
{
    public partial class frmGenerateYearlyBookingAnalysis : Form
    {
        frmHome Parent; 

        private readonly int[][] yearlyBookingData = new int[][]
       {
            new int[] { 10,12,8,15,20,25,22,18,14,17,19,23 },//2021
            new int[] { 9,11,13,16,21,24,15,20,15,18,20,25 },//2022
            new int[] { 8,10,14,17,22,28,27,21,16,19,21,29 },//2023
            new int[] { 11,13,15,18,24,29,30,23,19,20,22,31 },//2024
            new int[] { 6,9,23,13,18,15,24,20,34,21,17,24,28 }//2025
        };

        private readonly int[][] yearlyHourData = new int[][]
       {
            new int[] { 42,55,48,60,72,75,68,80,74,69,58,50 },//2021
            new int[] { 50,63,57,70,82,90,85,92,88,76,65,59  },//2022
            new int[] { 58,66,62,78,88,95,91,98,94,82,71,64 },//2023
            new int[] { 61,70,68,82,93,102,99,105,98,90,77,69 },//2024
            new int[] { 65,75,72,88,100,110,108,115,107,96,82,75 }//2025
        };

        private readonly string[] months =
        {
            "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec"
        };

        public frmGenerateYearlyBookingAnalysis()
        {
            InitializeComponent();
        }

        public frmGenerateYearlyBookingAnalysis(frmHome parent)
        {
            InitializeComponent();
            this.Parent = parent;
        }


        private void mnuHome_Click_1(object sender, EventArgs e)
        {
            frmHome nextForm = new frmHome();
            this.Hide();
            nextForm.Show();
        }

        private void mnuBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Parent.Visible = true;
        }

        private void mnuExit_Click_1(object sender, EventArgs e)
        {
            //Get confirmation from user on if they would kie to exit the app/form
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //check if user clicked yes
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
               

        private void frmGenerateYearlyBookingAnalysis_Load(object sender, EventArgs e)
        {
            cboYear.Items.Add("2021");
            cboYear.Items.Add("2022");
            cboYear.Items.Add("2023");
            cboYear.Items.Add("2024");
            cboYear.Items.Add("2025");

            cboYear.SelectedIndex = 0;

            InitializeChart();
            UpdateChart(0);
        }



        private void InitializeChart()
        {
            chtBookingAnalysis.Series.Clear();

            chtBookingAnalysis.ChartAreas[0].AxisX.Title = "Month";

            chtBookingAnalysis.ChartAreas[0].AxisY.Title = "Total Bookings & Hours";


            Series series = new Series
            {
                Name = "Monthly Bookings",
                ChartType = SeriesChartType.Column,
                BorderWidth = 3,
                Color = System.Drawing.Color.DarkGoldenrod,
                IsValueShownAsLabel = true

            };
            chtBookingAnalysis.Series.Add(series);

            Series hoursSeries = new Series
            {
                Name = "Total Hours",
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = System.Drawing.Color.DarkTurquoise,
                IsValueShownAsLabel = true,
                YAxisType = AxisType.Secondary
            };

            chtBookingAnalysis.Series.Add(hoursSeries);
            chtBookingAnalysis.ChartAreas[0].AxisY2.Title = "Hours";
            

        }

        private void UpdateChart(int yearIndex)
        {

            var bookingSeries = chtBookingAnalysis.Series["Monthly Bookings"];
            bookingSeries.Points.Clear();

            var hoursSeries = chtBookingAnalysis.Series["Total Hours"];
            hoursSeries.Points.Clear();

            for (int i = 0; i < months.Length; i++)
            {
                int bookings = yearlyBookingData[yearIndex][i];
                int hours = yearlyHourData[yearIndex][i];

                bookingSeries.Points.AddXY(months[i], bookings);
                hoursSeries.Points.AddXY(months[i], hours);
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart(cboYear.SelectedIndex);
        }

        private void mnuClientList_Click(object sender, EventArgs e)
        {
            frmLIstClients nextForm = new frmLIstClients();
            this.Hide();
            nextForm.Show();
        }

        private void mnuSearchClient_Click(object sender, EventArgs e)
        {
            frmSearchClient nextForm = new frmSearchClient();
            this.Hide();
            nextForm.Show();
        }

        private void mnuSitterList_Click(object sender, EventArgs e)
        {
            frmListSitters nextForm = new frmListSitters();
            this.Hide();
            nextForm.Show();
        }

        private void mnuSearchSitter_Click(object sender, EventArgs e)
        {
            frmSearchSitters nextForm = new frmSearchSitters();
            this.Hide();
            nextForm.Show();
        }

        private void bookingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBookings nextForm = new frmListBookings();
            this.Hide();
            nextForm.Show();
        }

        private void searchBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchBookings nextForm = new frmSearchBookings();
            this.Hide();
            nextForm.Show();
        }

        private void generateYearlySitterAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerateYearlySitterAnalysis nextForm = new frmGenerateYearlySitterAnalysis();
            this.Hide();
            nextForm.Show();
        }

    }
}

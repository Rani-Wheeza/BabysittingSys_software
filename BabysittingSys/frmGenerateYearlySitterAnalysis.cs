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
    public partial class frmGenerateYearlySitterAnalysis : Form
    {
        frmAdminDashBoard Parent;

        //Earings for each year
        private readonly double[][] yearlyData = new double[][]
        {
            new double[] {120, 150, 180, 200, 220, 250, 300, 280, 260, 240, 210, 190 },  //2024
            new double[] {100, 130, 160, 170, 190, 210, 240, 230, 220, 200, 180, 160 }, //2023
            new double[] {80, 110, 130, 140, 160, 180, 200, 190, 180, 160, 140, 120 }  //2022
        };

        private readonly string[] months =
        {
            "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec"
        };

        public frmGenerateYearlySitterAnalysis()
        {
            InitializeComponent();
        }

        public frmGenerateYearlySitterAnalysis(frmAdminDashBoard parent)
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

        private void mnuBookingList_Click(object sender, EventArgs e)
        {
            frmListBookings nextForm = new frmListBookings();
            this.Hide();
            nextForm.Show();
        }

        private void mnuSearchBooking_Click(object sender, EventArgs e)
        {
            frmSearchBookings nextForm = new frmSearchBookings();
            this.Hide();
            nextForm.Show();
        }

        private void generateYearlyBookingAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerateYearlyBookingAnalysis nextForm = new frmGenerateYearlyBookingAnalysis();
            this.Hide();
            nextForm.Show();
        }

        private void frmGenerateYearlySitterAnalysis_Load(object sender, EventArgs e)
        {
            //Years
            cboYear.Items.Add("2024");
            cboYear.Items.Add("2023");
            cboYear.Items.Add("2022");
            cboYear.SelectedIndex = 0;

            InitializeChart();
            UpdateChart(0);

        }

        private void InitializeChart()
        {
            chtSitterAnalysis.Series.Clear();
            chtSitterAnalysis.ChartAreas[0].AxisX.Title = "Month";
            chtSitterAnalysis.ChartAreas[0].AxisY.Title = "Earnings (€)";

            Series series = new Series
            {
                Name = "Top Earnings",
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = System.Drawing.Color.DarkSlateBlue,
                IsValueShownAsLabel = true

            };

            chtSitterAnalysis.Series.Add(series);

        }

        private void UpdateChart(int yearIndex)
        {
            var series = chtSitterAnalysis.Series["Top Earnings"];
            series.Points.Clear();

            double total = 0;

            for (int i = 0; i < months.Length; i++)
            {
                double value = yearlyData[yearIndex][i];
                total += value;
                series.Points.AddXY(months[i], value);
            }
            
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart(cboYear.SelectedIndex);
        }

        
    }
}


namespace PATPD.C9_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string tripDestination;
            double gallonsUsed;
            double milesCovered;

            while (double.TryParse(txtBxMilesTravelled.Text, out milesCovered) == false)
            {
                MessageBox.Show("Enter a numerical value to show number of miles travelled.");
                txtBxMilesTravelled.Focus();
            }

            while (double.TryParse(txtBxGallonsUsed.Text, out gallonsUsed) == false)
            {
                MessageBox.Show("Enter a numerical value to show number of gallons consumed.");
                txtBxGallonsUsed.Focus();
            }

            tripDestination = txtBxMilesTravelled.Text;

            if (tripDestination.Length < 1)
            {
                MessageBox.Show("Enter the name of the trip destination.");
                txtBxMilesTravelled.Focus();
            }

            else if (gallonsUsed >= 1 && milesCovered >= 1)
            {
                TripCalculatorClass myTrip = new TripCalculatorClass(tripDestination, milesCovered, gallonsUsed);
                txtBxMPG.Text = myTrip.MilesPerGallon().ToString("N2");
                txtBxMPG.Enabled = false;
                setVisibility(true);
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtBxTripDest.Clear();
            txtBxMilesTravelled.Text = "0";
            txtBxGallonsUsed.Text = "0";
            txtBxMPG.Visible = true;
            lblMPG.Visible = true;
            setVisibility(false);
        }

        private void setVisibility(bool visibilityValue)
        {
            lblMPG.Visible =visibilityValue;
            txtBxMPG.Visible= visibilityValue;
        }
    }
}
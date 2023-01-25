namespace ver_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dgvDrivers.DataSource = Parking.Drivers;
            dgvInGarage.DataSource = Parking.ParkedCars;
        }

        private void SetButtons()
        {
            btnParkIn.Enabled = (dgvTakenCar.Rows.Count > 0);
            btnDriveOut.Enabled = (dgvInGarage.Rows.Count > 0);
        }
        private void btnParkIn_Click(object sender, EventArgs e)
        {
            Parking.ParkIn(dgvDrivers.CurrentRow.DataBoundItem,
                           dgvTakenCar.CurrentRow.DataBoundItem);

            SetButtons();
        }

        private void btnDriveOut_Click(object sender, EventArgs e)
        {
            Parking.DriveOut(dgvDrivers.CurrentRow.DataBoundItem,
                             dgvInGarage.CurrentRow.DataBoundItem);


            SetButtons();
        }

        private void dgvDrivers_SelectionChanged(object sender, EventArgs e)
        {
            dgvTakenCar.DataSource = (dgvDrivers.CurrentRow.DataBoundItem as Person).TakenCar;

            SetButtons();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parking.Serializer();
        }
    }
}
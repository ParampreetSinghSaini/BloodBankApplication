using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blood_bank
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetData();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pc\Documents\BloodBankdb.mdf;Integrated Security=True;Connect Timeout=30");
      private void GetData()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DonorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DonorLbl.Text = dt.Rows[0][0].ToString();


            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from TransferTbl", Con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            TransferLbl.Text = dt1.Rows[0][0].ToString();



            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from EmployeeTbl", Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            EmployeeLbl.Text = dt2.Rows[0][0].ToString();


            SqlDataAdapter sda3 = new SqlDataAdapter("select Sum(BStock) from BloodTbl", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);

            int BStock = Convert.ToInt32(dt3.Rows[0][0].ToString());
            TotalLbl.Text = "" + BStock;
           






            SqlDataAdapter sda4 = new SqlDataAdapter("select BStock from BloodTbl where BGroup = '"+"O+"+"'", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            OplusNumLbl.Text = dt4.Rows[0][0].ToString();
            double oplusPercentage = (Convert.ToDouble(dt4.Rows[0][0].ToString())/BStock) *100;
            Oplusprogram.Value = Convert.ToInt32(oplusPercentage);




            SqlDataAdapter sda5 = new SqlDataAdapter("select BStock from BloodTbl where BGroup = '" + "AB+" + "'", Con);
            DataTable dt5= new DataTable();
            sda5.Fill(dt5);
            ABplusLbl.Text = dt5.Rows[0][0].ToString();
            double ABplusPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / BStock) * 100;
            ABplusProgress.Value = Convert.ToInt32(ABplusPercentage);





            SqlDataAdapter sda6 = new SqlDataAdapter("select BStock from BloodTbl where BGroup = '" + "O-" + "'", Con);
            DataTable dt6 = new DataTable();
            sda6.Fill(dt6);
            OminusLbl.Text = dt6.Rows[0][0].ToString();

            double OminusPercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / BStock) * 100;

            OminusProgress.Value = Convert.ToInt32(OminusPercentage);



            SqlDataAdapter sda7 = new SqlDataAdapter("select BStock from BloodTbl where BGroup = '" + "AB-" + "'", Con);
            DataTable dt7 = new DataTable();
            sda7.Fill(dt7);
            ABminusLbl.Text = dt7.Rows[0][0].ToString();

            double ABminusPercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / BStock) * 100;

            ABminusProgress.Value = Convert.ToInt32(ABminusPercentage);













            Con.Close();


        }

        
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            login k = new login();
            k.Show();
            this.Hide();
         
        }

        private void label3_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Donor d = new Donor();
            d.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
          DonateBlood d = new DonateBlood();
            d.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewDonor v = new ViewDonor();
            v.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewPatients p = new ViewPatients();
            p.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BloodStock b = new BloodStock();
            b.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            BloodTranser t = new BloodTranser();
            t.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            d.Show();
            this.Hide();
        }

        private void OplusNumLbl_Click(object sender, EventArgs e)
        {

        }
    }
}

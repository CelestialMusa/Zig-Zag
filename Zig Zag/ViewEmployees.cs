using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class ViewEmployees : Form
    {
        string stateMonthSal = "active";
        string stateOver50 = "";
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e00c(0)_256b2.png");
            pictureBoxBack.BackgroundImage = image;
            labelBack.Visible = true;
        }

        private void pictureBoxBack_MouseLeave(object sender, EventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e00c(0)_256b1.png");
            pictureBoxBack.BackgroundImage = image;
            labelBack.Visible = false;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Employees child = new Employees();
            ActiveForm.Hide();
            child.Show();
        }

        private void ViewEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd25535935DataSet10.list_names_and_snumbers_over_50_years' table. You can move, or remove it, as needed.
            this.list_names_and_snumbers_over_50_yearsTableAdapter3.Fill(this.d25535935DataSet10.list_names_and_snumbers_over_50_years);
            // TODO: This line of code loads data into the 'd25535935DataSet9.list_names_and_snumbers_over_50_years' table. You can move, or remove it, as needed.
            this.list_names_and_snumbers_over_50_yearsTableAdapter2.Fill(this.d25535935DataSet9.list_names_and_snumbers_over_50_years);
            // TODO: This line of code loads data into the 'd25535935DataSet8.list_names_and_snumbers_over_50_years' table. You can move, or remove it, as needed.
            this.list_names_and_snumbers_over_50_yearsTableAdapter1.Fill(this.d25535935DataSet8.list_names_and_snumbers_over_50_years);
            // TODO: This line of code loads data into the 'd25535935DataSet4.total_monthly_salary_for_staff' table. You can move, or remove it, as needed.
            this.total_monthly_salary_for_staffTableAdapter1.Fill(this.d25535935DataSet4.total_monthly_salary_for_staff);
            // TODO: This line of code loads data into the 'd25535935DataSet3.total_monthly_salary_for_staff' table. You can move, or remove it, as needed.
            //this.total_monthly_salary_for_staffTableAdapter.Fill(this.d25535935DataSet3.total_monthly_salary_for_staff);
            // TODO: This line of code loads data into the 'd25535935DataSet2.clinic_details' table. You can move, or remove it, as needed.
            this.clinic_detailsTableAdapter1.Fill(this.d25535935DataSet2.clinic_details);
            // TODO: This line of code loads data into the 'd25535935DataSet1.clinic_details' table. You can move, or remove it, as needed.
            this.clinic_detailsTableAdapter.Fill(this.d25535935DataSet1.clinic_details);
            // TODO: This line of code loads data into the 'd25535935DataSet.list_names_and_snumbers_over_50_years' table. You can move, or remove it, as needed.
            //this.list_names_and_snumbers_over_50_yearsTableAdapter.Fill(this.d25535935DataSet.list_names_and_snumbers_over_50_years);

        }

        private void pictureBoxStaff_History_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxStaff_History.Size = size;
            Size size2 = new Size(450, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(165, 451);
            pictureBoxStaff_History.Location = new Point(463, 551);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0d6(0)_256.png");
            pictureBoxStaff_History.BackgroundImage = image;
            labelSystem.Text = "Total monthly salary for staff";
            labelSystem.Location = new Point(191, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);           
        }

        private void labelSystem_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBoxStaff_History_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxStaff_History.Size = size;
            pictureBoxStaff_History.Location = new Point(472, 553);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0d6(0)_2561.png");
            pictureBoxStaff_History.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
            //labelSystem.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            Size size2 = new Size(720, 1);            
            pictureBoxOver50.Size = size;
            pictureBox1.Size = size2;
            pictureBoxOver50.Location = new Point(610, 551);
            pictureBox1.Location = new Point(85, 451);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\themify_e699(0)_2561.png");
            pictureBoxOver50.BackgroundImage = image;
            labelSystem.Text = "Names and staff numbers for staff over 50 years";
            labelSystem.Location = new Point(90, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);            
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);             
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxOver50.Size = size;            
            pictureBoxOver50.Location = new Point(618, 553);            
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\themify_e699(0)_256.png");
            pictureBoxOver50.BackgroundImage = image;           
            //labelSystem.Location = new Point(191, 417);
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
            //labelSystem.Visible = false;
        }

        private void pictureBoxStaff_History_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxOver50_Click(object sender, EventArgs e)
        {
            stateMonthSal = "inactive";
            stateOver50 = "active";

            dataGridViewOver50.Visible = true;
            dataGridViewMonthlySalEmploy.Visible = false;

            if (stateOver50.Equals("active"))
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\themify_e699(0)_256.png");
                pictureBoxOver50.BackgroundImage = image;
                labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
                labelSystem.Location = new Point(90, 417);                
                labelSystem.Text = "Names and staff numbers for staff over 50 years";
                labelSystem.Visible = true;

                Image image2 = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0d6(0)_2561.png");
                pictureBoxStaff_History.BackgroundImage = image2;                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelBack_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxUserProfile_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            stateMonthSal = "inactive";
            stateOver50 = "active";

            dataGridViewMonthlySalEmploy.Visible = true;
            dataGridViewOver50.Visible = false;

            if (stateOver50.Equals("active"))
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\themify_e699(0)_256.png");
                pictureBoxOver50.BackgroundImage = image;
                labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
                labelSystem.Location = new Point(90, 417);
                labelSystem.Text = "Names and staff numbers for staff over 50 years";
                labelSystem.Visible = true;

                Image image2 = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0d6(0)_2561.png");
                pictureBoxStaff_History.BackgroundImage = image2;
            }
        }

        private void pictureBox2_MouseMove_1(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxStaff_History.Size = size;
            Size size2 = new Size(450, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(165, 451);
            pictureBoxStaff_History.Location = new Point(463, 551);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0d6(0)_256.png");
            pictureBoxStaff_History.BackgroundImage = image;
            labelSystem.Text = "Total monthly salary for staff";
            labelSystem.Location = new Point(191, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxStaff_History.Size = size;
            pictureBoxStaff_History.Location = new Point(472, 553);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0d6(0)_2561.png");
            pictureBoxStaff_History.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
            //labelSystem.Visible = false;
        }
    }
}

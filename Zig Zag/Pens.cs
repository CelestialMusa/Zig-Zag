using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class Pens : Form
    {
        public Pens()
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
            SystemWin child = new SystemWin();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBoxVieInvoicesBy_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxVieInvoicesBy.Size = size;
            pictureBoxVieInvoicesBy.Location = new Point(464, 561);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e066(0)_2561.png");
            pictureBoxVieInvoicesBy.BackgroundImage = image;
            labelSystem.Text = "Total pens in each clinic";
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            labelSystem.Location = new Point(430, 486);
            pictureBox1.BackColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxVieInvoicesBy_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxVieInvoicesBy.Size = size;
            pictureBoxVieInvoicesBy.Location = new Point(474, 563);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e066(0)_256.png");
            pictureBoxVieInvoicesBy.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBox1.BackColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBoxViewInvoices_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxViewInvoices.Size = size;
            pictureBoxViewInvoices.Location = new Point(612, 561);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e040(0)_256.png");
            pictureBoxViewInvoices.BackgroundImage = image;
            labelSystem.Text = "Available pens in each clinic";
            labelSystem.Location = new Point(400, 486);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBox1.BackColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxViewInvoices_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxViewInvoices.Size = size;
            pictureBoxViewInvoices.Location = new Point(620, 563);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e040(0)_2561.png");
            pictureBoxViewInvoices.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBox1.BackColor = Color.FromArgb(255, 135, 25);
        }

        private void Pens_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd25535935DataSet14.total_num_of_pens_in_each_clinic' table. You can move, or remove it, as needed.
            this.total_num_of_pens_in_each_clinicTableAdapter.Fill(this.d25535935DataSet14.total_num_of_pens_in_each_clinic);
            // TODO: This line of code loads data into the 'd25535935DataSet13.list_available_pens_in_each_clinic' table. You can move, or remove it, as needed.
            this.list_available_pens_in_each_clinicTableAdapter.Fill(this.d25535935DataSet13.list_available_pens_in_each_clinic);
        }

        private void pictureBoxVieInvoicesBy_Click(object sender, EventArgs e)
        {
            dataGridViewToTPensEachClinic.Visible = true;
            dataGridViewAvailablePens.Visible = false;
        }

        private void pictureBoxViewInvoices_Click(object sender, EventArgs e)
        {
            dataGridViewToTPensEachClinic.Visible = false;
            dataGridViewAvailablePens.Visible = true;
        }

        private void Pens_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
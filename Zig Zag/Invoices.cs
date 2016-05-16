using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBoxVieInvoicesBy_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxVieInvoicesBy.Size = size;
            pictureBoxVieInvoicesBy.Location = new Point(464, 561);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e07c(1)_256.png");
            pictureBoxVieInvoicesBy.BackgroundImage = image;
            labelSystem.Text = "View invoice by pet owner/date";
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            labelSystem.Location = new Point(393, 502);
            pictureBox1.BackColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxVieInvoicesBy_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxVieInvoicesBy.Size = size;
            pictureBoxVieInvoicesBy.Location = new Point(474, 563);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e07c(1)_2561.png");
            pictureBoxVieInvoicesBy.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBox1.BackColor = Color.FromArgb(255, 135, 25);
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

        private void Invoices_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxViewInvoices_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxViewInvoices.Size = size;
            pictureBoxViewInvoices.Location = new Point(612, 561);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f011(0)_256.png");
            pictureBoxViewInvoices.BackgroundImage = image;
            labelSystem.Text = "View a list of all invoices";
            labelSystem.Location = new Point(430, 502);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBox1.BackColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxViewInvoices_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxViewInvoices.Size = size;
            pictureBoxViewInvoices.Location = new Point(620, 563);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f011(0)_2561.png");
            pictureBoxViewInvoices.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBox1.BackColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBoxVieInvoicesBy_Click(object sender, EventArgs e)
        {
            panelViewInvoicesBy.Visible = true;
            panelViewInvoices.Visible = false;
        }

        private void pictureBoxViewInvoices_Click(object sender, EventArgs e)
        {
            panelViewInvoicesBy.Visible = false;
            panelViewInvoices.Visible = true;
        }
    }
}
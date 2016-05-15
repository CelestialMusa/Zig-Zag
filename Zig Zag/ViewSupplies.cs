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
    public partial class ViewSupplies : Form
    {
        public ViewSupplies()
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
            Supplies child = new Supplies();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBox2.Size = size;
            Size size2 = new Size(580, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(98, 451);
            pictureBox2.Location = new Point(466, 561);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f011(0)_256.png");
            pictureBox2.BackgroundImage = image;
            labelSystem.Text = "List pharmaceutical supplies to be ordered";
            labelSystem.Location = new Point(101, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBox2.Size = size;
            pictureBox2.Location = new Point(474, 563);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f011(0)_2561.png");
            pictureBox2.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBoxOver50_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxOver50.Size = size;
            Size size2 = new Size(760, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(5, 451);
            pictureBoxOver50.Location = new Point(610, 561);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e034(0)_256.png");
            pictureBoxOver50.BackgroundImage = image;
            labelSystem.Text = "Total cost of surgical and non-surgical supplies in stock";
            labelSystem.Location = new Point(10, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxOver50_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxOver50.Size = size;
            pictureBoxOver50.Location = new Point(620, 563);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e034(0)_2561.png");
            pictureBoxOver50.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
        }

        private void ViewSupplies_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

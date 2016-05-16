using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class Treatment : Form
    {
        public Treatment()
        {
            InitializeComponent();
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(106, 75);
            pictureBox5.Size = size;
            pictureBox5.Location = new Point(889, 69);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\et-line_e006(0)_2561.png");
            pictureBox5.BackgroundImage = image;
            labelViewAll.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(96, 65);
            pictureBox5.Size = size;
            pictureBox5.Location = new Point(904, 71);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\et-line_e006(0)_256.png");
            pictureBox5.BackgroundImage = image;
            labelViewAll.Visible = false;
        }

        private void pictureBoxGo_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(106, 75);
            pictureBoxGo.Size = size;
            pictureBoxGo.Location = new Point(770, 347);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_256.png");
            pictureBoxGo.BackgroundImage = image;
            labelSubmit.Visible = true;
        }

        private void pictureBoxGo_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(96, 65);
            pictureBoxGo.Size = size;
            pictureBoxGo.Location = new Point(776, 349);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_2561.png");
            pictureBoxGo.BackgroundImage = image;
            labelSubmit.Visible = false;
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ViewTreatment child = new ViewTreatment();
            ActiveForm.Hide();
            child.Show();
        }

        private void Treatment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
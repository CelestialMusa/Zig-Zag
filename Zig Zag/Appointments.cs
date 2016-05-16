using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class Appointments : Form
    {
        private string stateAdd = "active";
        private string stateRemove = "";

        public Appointments()
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

        private void Appointments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void pictureBoxAddUserBTN_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e10f(2)_256.png");
            pictureBoxAddUserBTN.BackgroundImage = image;
            labelAdd.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxAddUserBTN_MouseLeave(object sender, EventArgs e)
        {
            if (stateAdd == "active")
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e10f(2)_256.png");
                pictureBoxAddUserBTN.BackgroundImage = image;
                labelAdd.ForeColor = Color.FromArgb(0, 85, 127);
            }
            else
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e10f(2)_2561.png");
                pictureBoxAddUserBTN.BackgroundImage = image;
                labelAdd.ForeColor = Color.FromArgb(254, 135, 25);
            }
        }

        private void pictureBoxRemoveUserBTN_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e111(1)_256.png");
            pictureBoxRemoveUserBTN.BackgroundImage = image;
            labelRemove.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxRemoveUserBTN_MouseLeave(object sender, EventArgs e)
        {
            if (stateRemove == "active")
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e111(1)_256.png");
                pictureBoxRemoveUserBTN.BackgroundImage = image;
                labelRemove.ForeColor = Color.FromArgb(0, 85, 127);
            }
            else
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e111(1)_2561.png");
                pictureBoxRemoveUserBTN.BackgroundImage = image;
                labelRemove.ForeColor = Color.FromArgb(254, 135, 25);
            }
        }

        private void pictureBoxAddUserBTN_Click(object sender, EventArgs e)
        {
            stateAdd = "active";
            stateRemove = "inactive";

            panelRemoveUser.Visible = false;
            panel_AddUser.Visible = true;
            pictureBox5.Visible = true;

            if (stateAdd.Equals("active"))
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e10f(2)_256.png");
                pictureBoxAddUserBTN.BackgroundImage = image;
                labelAdd.ForeColor = Color.FromArgb(0, 85, 127);

                Image image2 = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e111(1)_2561.png");
                pictureBoxRemoveUserBTN.BackgroundImage = image2;
                labelRemove.ForeColor = Color.FromArgb(254, 135, 25);
            }
        }

        private void pictureBoxRemoveUserBTN_Click(object sender, EventArgs e)
        {
            stateAdd = "inactive";
            stateRemove = "active";

            panelRemoveUser.Visible = true;
            panel_AddUser.Visible = false;
            pictureBox5.Visible = false;

            if (stateRemove.Equals("active"))
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e111(1)_256.png");
                pictureBoxRemoveUserBTN.BackgroundImage = image;
                labelRemove.ForeColor = Color.FromArgb(0, 85, 127);

                Image image2 = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e10f(2)_2561.png");
                pictureBoxAddUserBTN.BackgroundImage = image2;
                labelAdd.ForeColor = Color.FromArgb(254, 135, 25);
            }
        }

        private void pictureBoxRemoveUserGo_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(106, 75);
            pictureBoxRemoveUserGo.Size = size;
            pictureBoxRemoveUserGo.Location = new Point(284, 396);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_256.png");
            pictureBoxRemoveUserGo.BackgroundImage = image;
            label2.Visible = true;
        }

        private void pictureBoxRemoveUserGo_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(96, 65);
            pictureBoxRemoveUserGo.Size = size;
            pictureBoxRemoveUserGo.Location = new Point(294, 398);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_2561.png");
            pictureBoxRemoveUserGo.BackgroundImage = image;
            label2.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ViewAppointments child = new ViewAppointments();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBoxGo_Click(object sender, EventArgs e)
        {
            dtpAppoint.Format = DateTimePickerFormat.Time;
            dtpAppoint.ShowUpDown = true;


        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;
        }
    }
}
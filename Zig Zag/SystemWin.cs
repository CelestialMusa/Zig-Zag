using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class SystemWin : Form
    {
        public SystemWin()
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
            FunctionalWindow child = new FunctionalWindow();
            ActiveForm.Hide();
            child.Show();
        }

        private void SystemWin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employees child = new Employees();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBox1.Size = size;
            pictureBox1.Location = new Point(280, 342);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\icomoon_e657(2)_256.png");
            pictureBox1.BackgroundImage = image;
            labelEmployees.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBox1.Size = size;
            pictureBox1.Location = new Point(292, 344);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\icomoon_e657(2)_2561.png");
            pictureBox1.BackgroundImage = image;
            labelEmployees.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Pets child = new Pets();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBox7.Size = size;
            pictureBox7.Location = new Point(508, 344);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\icomoon_e604(3)_256.png");
            pictureBox7.BackgroundImage = image;
            label2.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBox7.Size = size;
            pictureBox7.Location = new Point(518, 344);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\icomoon_e604(3)_2561.png");
            pictureBox7.BackgroundImage = image;
            label2.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBox6.Size = size;
            pictureBox6.Location = new Point(282, 489);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f011(0)_256.png");
            pictureBox6.BackgroundImage = image;
            label5.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBox6.Size = size;
            pictureBox6.Location = new Point(292, 491);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f011(0)_2561.png");
            pictureBox6.BackgroundImage = image;
            label5.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Invoices child = new Invoices();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBoxExaminations_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBoxExaminations.Size = size;
            pictureBoxExaminations.Location = new Point(392, 489);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0f1(2)_256.png");
            pictureBoxExaminations.BackgroundImage = image;
            label7.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBoxExaminations_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBoxExaminations.Size = size;
            pictureBoxExaminations.Location = new Point(402, 491);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0f1(2)_2561.png");
            pictureBoxExaminations.BackgroundImage = image;
            label7.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxExaminations_Click(object sender, EventArgs e)
        {
            Examinations child = new Examinations();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBox16.Size = size;
            pictureBox16.Location = new Point(623, 342);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e07c(1)_256.png");
            pictureBox16.BackgroundImage = image;
            label4.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBox16.Size = size;
            pictureBox16.Location = new Point(633, 344);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e07c(1)_2561.png");
            pictureBox16.BackgroundImage = image;
            label4.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Customers child = new Customers();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(742, 342);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f04a(0)_2561.png");
            pictureBox4.BackgroundImage = image;
            label6.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(750, 344);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f04a(1)_256.png");
            pictureBox4.BackgroundImage = image;
            label6.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Appointments child = new Appointments();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBox3.Size = size;
            pictureBox3.Location = new Point(625, 489);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e081(3)_256.png");
            pictureBox3.BackgroundImage = image;
            label8.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBox3.Size = size;
            pictureBox3.Location = new Point(633, 491);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e081(3)_2561.png");
            pictureBox3.BackgroundImage = image;
            label8.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pens child = new Pens();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Treatment child = new Treatment();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBox13.Size = size;
            pictureBox13.Location = new Point(510, 489);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0f0(1)_256.png");
            pictureBox13.BackgroundImage = image;
            label10.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBox13.Size = size;
            pictureBox13.Location = new Point(518, 491);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0f0(1)_2561.png");
            pictureBox13.BackgroundImage = image;
            label10.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBox5.Size = size;
            pictureBox5.Location = new Point(390, 342);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0fa(0)_256.png");
            pictureBox5.BackgroundImage = image;
            label3.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBox5.Size = size;
            pictureBox5.Location = new Point(402, 344);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0fa(0)_2561.png");
            pictureBox5.BackgroundImage = image;
            label3.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Supplies child = new Supplies();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(90, 82);
            pictureBox15.Size = size;
            pictureBox15.Location = new Point(743, 499);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f022(0)_256.png");
            pictureBox15.BackgroundImage = image;
            label9.ForeColor = Color.FromArgb(255, 135, 25);
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(80, 72);
            pictureBox15.Size = size;
            pictureBox15.Location = new Point(750, 501);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f022(0)_2561.png");
            pictureBox15.BackgroundImage = image;
            label9.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Reports child = new Reports();
            ActiveForm.Hide();
            child.Show();
        }
    }
}
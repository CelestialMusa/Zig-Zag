using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zig_Zag
{
    public partial class FunctionalWindow : Form
    {
        StreamReader inputStream;
        string[] a = new string[7];
        List<ClassUsers> array = new List<ClassUsers>();

        ClassUsers user;

        private static int position;
        private static string name;
        private static string surname;
        private static string empNum;
        private static string typeUser;
        public FunctionalWindow()
        {
            InitializeComponent();
        }

        private void FunctionalWindow_Load(object sender, EventArgs e)
        {
            inputStream = File.OpenText("C:\\IntelTechs\\files\\Users.txt");

            string line;
            int count = 0;

            line = inputStream.ReadLine();

            while (line != null)
            {
                a = line.Split(',');

                string typeUser = a[0];
                string name = a[1];
                string lastName = a[2];
                string userName = a[3];
                string password = a[4];
                string question = a[5];
                string answer = a[6];

                array.Add(user = new ClassUsers(typeUser, name, lastName, userName, password, question, answer));

                line = inputStream.ReadLine();
                count++;
            }
            inputStream.Close();

            labelUserName.Text = name + " " + surname;
            Display();
        }

        public static void PopDISP(int Position, string Name, string Surname, string EmpNum, string TypeUser)
        {
            name = Name;
            position = Position;
            surname = Surname;
            empNum = EmpNum;
            typeUser = TypeUser;
        }

        public void Display()
        {
            FileStream fs = new System.IO.FileStream(@"C:\\IntelTechs\\profile\\" + empNum + ".bmp", FileMode.Open, FileAccess.Read);
            pictureBox_Sec_Screen_User_Picture.Image = Image.FromStream(fs);
            pictureBox_Sec_Screen_User_Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            fs.Close();
        }

        private void FunctionalWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
            if (MessageBox.Show("Are you sure you would like to log out?", "Log out", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Home child1 = new Home();
                ActiveForm.Hide();
                child1.Show();
            }
        }

        private void pictureToolsIco_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(129, 120);            
            pictureToolsIco.Size = size;
            pictureToolsIco.Location = new Point(149, 368);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Material Icons_e30c(2)_2561.png");
            pictureToolsIco.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
            labelSys1.Visible = true;
            labelSys2.Visible = true;
            labelSys3.Visible = true;
        }

        private void pictureToolsIco_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(119, 110);            
            pictureToolsIco.Size = size;
            pictureToolsIco.Location = new Point(164, 370);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Material Icons_e30c(2)_256.png");
            pictureToolsIco.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
            labelSys1.Visible = false;
            labelSys2.Visible = false;
            labelSys3.Visible = false;
        }

        private void pictureBoxSettingsIco_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(139, 130);
            pictureBoxSettingsIco.Size = size;
            pictureBoxSettingsIco.Location = new Point(386, 366);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Entypo_d83d(0)_2561.png");
            pictureBoxSettingsIco.BackgroundImage = image;
            labelUsers.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSettings.BackColor = Color.FromArgb(0, 85, 127);
            labelUse1.Visible = true;
            labelUse2.Visible = true;
            labelUse3.Visible = true;
        }

        private void pictureBoxSettingsIco_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(119, 110);
            pictureBoxSettingsIco.Size = size;
            pictureBoxSettingsIco.Location = new Point(401, 370);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Entypo_d83d(0)_256.png");
            pictureBoxSettingsIco.BackgroundImage = image;
            labelUsers.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSettings.BackColor = Color.FromArgb(255, 135, 25);
            labelUse1.Visible = false;
            labelUse2.Visible = false;
            labelUse3.Visible = false;
        }

        private void pictureBoxInfoIco_MouseMove(object sender, MouseEventArgs e)
        {
             Size size = new Size(139, 130);
             pictureBoxInfoIco.Size = size;
             pictureBoxInfoIco.Location = new Point(597, 366);
             Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f129(0)_2561.png");
             pictureBoxInfoIco.BackgroundImage = image;
             labelInfo.ForeColor = Color.FromArgb(255, 135, 25);
             pictureBoxInfoLine.BackColor = Color.FromArgb(0, 85, 127);
             labelInfo1.Visible = true;
             labelInfo2.Visible = true;
             labelInfo3.Visible = true;           
        }

        private void pictureBoxInfoIco_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(119, 110);
            pictureBoxInfoIco.Size = size;
            pictureBoxInfoIco.Location = new Point(612, 370);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f129(0)_256.png");
            pictureBoxInfoIco.BackgroundImage = image;
            labelInfo.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxInfoLine.BackColor = Color.FromArgb(255, 135, 25);
            labelInfo1.Visible = false;
            labelInfo2.Visible = false;
            labelInfo3.Visible = false;
        }

        private void pictureBoxVisitIco_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(139, 130);
            pictureBoxVisitIco.Size = size;
            pictureBoxVisitIco.Location = new Point(822, 366);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linea_a4(1)_2561.png");
            pictureBoxVisitIco.BackgroundImage = image;
            labelWebsite.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxWebsiteLine.BackColor = Color.FromArgb(0, 85, 127);
            labelWeb1.Visible = true;
            labelWeb2.Visible = true;
            labelWeb3.Visible = true;
        }

        private void pictureBoxVisitIco_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(119, 110);
            pictureBoxVisitIco.Size = size;
            pictureBoxVisitIco.Location = new Point(837, 370);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linea_a4(1)_256.png");
            pictureBoxVisitIco.BackgroundImage = image;
            labelWebsite.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxWebsiteLine.BackColor = Color.FromArgb(255, 135, 25);
            labelWeb1.Visible = false;
            labelWeb2.Visible = false;
            labelWeb3.Visible = false;
        }

        private void pictureBoxSettingsIco_Click(object sender, EventArgs e)
        {
            if (typeUser.Equals("Administrator"))
            {
                Users child = new Users();
                ActiveForm.Hide();
                child.Show();
            }
            else
            {
                MessageBox.Show("Please note that you are not a system admin and may not access this function.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureToolsIco_Click(object sender, EventArgs e)
        {
            SystemWin child = new SystemWin();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBoxInfoIco_Click(object sender, EventArgs e)
        {
            Information child = new Information();
            ActiveForm.Hide();
            child.Show();
        }
    }
}

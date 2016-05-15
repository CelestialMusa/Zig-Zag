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
    public partial class Users : Form
    {
        string stateAdd = "";
        string stateRemove = "";
        string stateEddit = "";

        public Users()
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

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Wel_Screen_Lock_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_256.png");
            pictureBox_Wel_Screen_Lock.BackgroundImage = image;
        }

        private void pictureBox_Wel_Screen_Lock_MouseLeave(object sender, EventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_2561.png");
            pictureBox_Wel_Screen_Lock.BackgroundImage = image;
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
            if(stateRemove == "active")
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

        private void pictureBoxEditUserBTN_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e113(0)_256.png");
            pictureBoxEditUserBTN.BackgroundImage = image;
            labelEdit.ForeColor = Color.FromArgb(0, 85, 127);            
        }

        private void pictureBoxEditUserBTN_MouseLeave(object sender, EventArgs e)
        {
            if(stateEddit == "active")
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e113(0)_256.png");
                pictureBoxEditUserBTN.BackgroundImage = image;
                labelEdit.ForeColor = Color.FromArgb(0, 85, 127);
            }
            else
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e113(0)_2561.png");
                pictureBoxEditUserBTN.BackgroundImage = image;
                labelEdit.ForeColor = Color.FromArgb(254, 135, 25);
            }            
        }

        private void pictureBoxAddUserBTN_Click(object sender, EventArgs e)
        {
            stateAdd = "active";
            stateRemove = "inactive";
            stateEddit = "inactive";
            panelRemoveUser.Visible = false;
            panel_AddUser.Visible = true;
            panelEdditUser.Visible = false;

            if(stateAdd.Equals("active"))
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e10f(2)_256.png");
                pictureBoxAddUserBTN.BackgroundImage = image;
                labelAdd.ForeColor = Color.FromArgb(0, 85, 127);

                Image image2 = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e111(1)_2561.png");
                pictureBoxRemoveUserBTN.BackgroundImage = image2;
                labelRemove.ForeColor = Color.FromArgb(254, 135, 25);

                Image image3 = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e113(0)_2561.png");
                pictureBoxEditUserBTN.BackgroundImage = image3;
                labelEdit.ForeColor = Color.FromArgb(254, 135, 25);
            }            
        }

        private void pictureBoxRemoveUserBTN_Click(object sender, EventArgs e)
        {
            stateAdd = "inactive";
            stateRemove = "active";
            stateEddit = "inactive";
            panelRemoveUser.Visible = true;
            panel_AddUser.Visible = false;
            panelEdditUser.Visible = false;


            if (stateRemove.Equals("active"))
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e111(1)_256.png");
                pictureBoxRemoveUserBTN.BackgroundImage = image;
                labelRemove.ForeColor = Color.FromArgb(0, 85, 127);

                Image image2 = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e10f(2)_2561.png");
                pictureBoxAddUserBTN.BackgroundImage = image2;
                labelAdd.ForeColor = Color.FromArgb(254, 135, 25);

                Image image3 = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e113(0)_2561.png");
                pictureBoxEditUserBTN.BackgroundImage = image3;
                labelEdit.ForeColor = Color.FromArgb(254, 135, 25);
            }
        }

        private void pictureBoxEditUserBTN_Click(object sender, EventArgs e)
        {
            stateAdd = "inactive";
            stateRemove = "inactive";
            stateEddit = "active";
            panelRemoveUser.Visible = false;
            panel_AddUser.Visible = false;
            panelEdditUser.Visible = true;


            if (stateEddit.Equals("active"))
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e113(0)_256.png");
                pictureBoxEditUserBTN.BackgroundImage = image;
                labelEdit.ForeColor = Color.FromArgb(0, 85, 127);

                Image image2 = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e111(1)_2561.png");
                pictureBoxRemoveUserBTN.BackgroundImage = image2;
                labelRemove.ForeColor = Color.FromArgb(254, 135, 25);

                Image image3 = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e10f(2)_2561.png");
                pictureBoxAddUserBTN.BackgroundImage = image3;
                labelAdd.ForeColor = Color.FromArgb(254, 135, 25);
            }
        }

        private void pictureBoxEditGo_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_256.png");
            pictureBoxEditGo.BackgroundImage = image;
        }

        private void pictureBoxEditGo_MouseLeave(object sender, EventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_2561.png");
            pictureBoxEditGo.BackgroundImage = image;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_2561.png");
            pictureBoxRemoveUserGo.BackgroundImage = image;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_256.png");
            pictureBoxRemoveUserGo.BackgroundImage = image;
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }
    }
}

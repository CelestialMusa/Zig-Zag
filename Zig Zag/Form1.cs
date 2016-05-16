using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class Home : Form
    {
        private StreamReader inputStream;
        private string[] a = new string[7];
        private List<ClassUsers> array = new List<ClassUsers>();
        private int count = 0;

        private ClassUsers user;

        public Home()
        {
            InitializeComponent();
        }

        private void pictureBoxLoginButton_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e098(0)_256.png");
            pictureBoxLoginButton.BackgroundImage = image;
            labelInform.Visible = true;
        }

        private void pictureBoxLoginButton_MouseLeave(object sender, EventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e096(1)_256.png");
            pictureBoxLoginButton.BackgroundImage = image;
            labelInform.Visible = false;
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBoxLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user = comboBoxUser.SelectedItem.ToString();
                string arrayUser;

                for (int i = 0; i < array.Count; i++)
                {
                    if ((arrayUser = array[i].getUserName()).Equals(user))
                    {
                        if (textBoxPass.Text == array[i].getPassword())
                        {
                            FunctionalWindow.PopDISP(i, array[i].getName(), array[i].getLastName(), array[i].getUserName(), array[i].getTypeUser());

                            FunctionalWindow child1 = new FunctionalWindow();
                            ActiveForm.Hide();
                            child1.Show();
                        }
                        else
                        {
                            if (MessageBox.Show("Invalid Password, would you like to retrieve your password?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                            {
                                ForgotPass child = new ForgotPass();
                                ActiveForm.Hide();
                                child.Show();
                            }
                            else
                            {
                                textBoxPass.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a user to proceed");
            }
        }

        private void Home_Load(object sender, EventArgs e)
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

            for (int i = 0; i < array.Count; i++)
            {
                comboBoxUser.Items.Add(array[i].getUserName());
            }
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxUser.ForeColor = Color.Black;
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxUser_Click(object sender, EventArgs e)
        {
            comboBoxUser.ForeColor = Color.Black;
        }

        private void textBoxPass_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.Black;
            }
            count++;
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
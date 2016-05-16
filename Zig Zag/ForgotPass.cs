using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class ForgotPass : Form
    {
        private string selectedUser;
        private string password;
        private string answer;
        private StreamReader inputStream;
        private string[] a = new string[7];
        private List<ClassUsers> array = new List<ClassUsers>();
        public int count = 0;

        private ClassUsers user;

        public ForgotPass()
        {
            InitializeComponent();
        }

        private void pictureBoxLoginButton_Click(object sender, EventArgs e)
        {
            selectedUser = comBox_ForgotPass_UserName.SelectedIndex.ToString();
            try
            {
                if (!(textBox_ForgotPass_Password.Text == ""))
                {
                    password = array[Convert.ToInt32(selectedUser)].getPassword();
                    answer = array[Convert.ToInt32(selectedUser)].getAnswer();

                    if (answer.Equals(textBox_ForgotPass_Password.Text))
                    {
                        MessageBox.Show("Your password is: " + password, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_ForgotPass_Password.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Your answer is incorrect. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_ForgotPass_Password.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an answer.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForgotPass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comBox_ForgotPass_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string user;

            for (int i = 0; i < array.Count; i++)
            {
                user = array[i].getUserName();

                if (user.Equals(comBox_ForgotPass_UserName.SelectedItem.ToString()))
                {
                    labelQuestion.Text = array[i].getQuestion() + "? (Note answer is case sensitive)";
                }
            }
            labelQuestion.Visible = true;
        }

        private void comBox_ForgotPass_UserName_Click(object sender, EventArgs e)
        {
            comBox_ForgotPass_UserName.ForeColor = Color.Black;
        }

        private void textBox_ForgotPass_Password_Click(object sender, EventArgs e)
        {
            if (count < 1)
            {
                textBox_ForgotPass_Password.Text = "";
                textBox_ForgotPass_Password.ForeColor = Color.Black;
            }
            count++;
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

        private void ForgotPass_Load(object sender, EventArgs e)
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
                comBox_ForgotPass_UserName.Items.Add(array[i].getUserName());
            }
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
            Home child = new Home();
            ActiveForm.Hide();
            child.Show();
        }
    }
}
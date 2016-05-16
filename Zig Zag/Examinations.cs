using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Zig_Zag
{
    public partial class Examinations : Form
    {
        private string connectionstring = @"Data Source=196.253.61.51; Database=d25535935; User ID= root; Password='inteltechs'";
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private DataTable myDataTable;

        public Examinations()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionstring);
            myDataTable = new DataTable();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd25535935DataSet21.treatment_type' table. You can move, or remove it, as needed.
            this.treatment_typeTableAdapter.Fill(this.d25535935DataSet21.treatment_type);
            // TODO: This line of code loads data into the 'd25535935DataSet20.pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.d25535935DataSet20.pet);
            // TODO: This line of code loads data into the 'd25535935DataSet17.list_staff_members' table. You can move, or remove it, as needed.
            this.list_staff_membersTableAdapter.Fill(this.d25535935DataSet17.list_staff_members);

            ViewExaminations child = new ViewExaminations();
            ActiveForm.Hide();
            child.Show();
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

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(106, 75);
            pictureBox1.Size = size;
            pictureBox1.Location = new Point(770, 347);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_256.png");
            pictureBox1.BackgroundImage = image;
            label2.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(96, 65);
            pictureBox1.Size = size;
            pictureBox1.Location = new Point(776, 349);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_2561.png");
            pictureBox1.BackgroundImage = image;
            label2.Visible = false;
        }

        private void Examinations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd25535935DataSet25.get_medical_staff' table. You can move, or remove it, as needed.
            this.get_medical_staffTableAdapter.Fill(this.d25535935DataSet25.get_medical_staff);
            // TODO: This line of code loads data into the 'd25535935DataSet21.treatment_type' table. You can move, or remove it, as needed.
            this.treatment_typeTableAdapter.Fill(this.d25535935DataSet21.treatment_type);
            // TODO: This line of code loads data into the 'd25535935DataSet20.pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.d25535935DataSet20.pet);
            // TODO: This line of code loads data into the 'd25535935DataSet17.list_staff_members' table. You can move, or remove it, as needed.
            this.list_staff_membersTableAdapter.Fill(this.d25535935DataSet17.list_staff_members);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int staff_num = (int)cmbStaff.SelectedValue;
                loadPens(staff_num);
                loadsPets(staff_num);
            }
            catch(Exception ex)
            {
                
            }
        }

        public void loadsPets(int staff_num)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "get_pets";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@staff_num", MySqlDbType.Int32)).Value = staff_num;

                reader = command.ExecuteReader();

                cmbPets.Items.Clear();

                while (reader.Read())
                {
                    cmbPets.Items.Add(new { PetID = reader["PET_ID"].ToString(), PetDescript = reader["PET_DESCRIPTION"].ToString() });
                }

                cmbPets.ValueMember = "PetID";
                cmbPets.DisplayMember = "PetDescript";
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void loadPens(int staff_num)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "get_pens";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@staff_num", MySqlDbType.Int32)).Value = staff_num;

                reader = command.ExecuteReader();

                cmbPens.Items.Clear();
                
                while (reader.Read())
                {
                    cmbPens.Items.Add(new { PenID = reader["PEN_NUM"].ToString(), PenStatus = reader["STATUS"].ToString() });
                }

                cmbPens.ValueMember = "PenID";
                cmbPens.DisplayMember = "PenID";
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBoxGo_Click(object sender, EventArgs e)
        {
            string descript = txtDescr.Text;
            string pet_num = (string) cmbPets.SelectedValue;
            int staff_num =  (int) cmbStaff.SelectedValue;
            string admin = cmbAdmin.SelectedText;
            

            if(admin=="Yes")
            {
                admin = "0";
            }
            else
            {
                admin = "1";
            }

            string pen_num = (string) cmbPens.SelectedValue;

            insertExam(descript, pet_num, staff_num, admin, pen_num);
        }

        public void insertExam(string descript,string pet_num,int staff_num,string admin,string pen_num)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert_examination";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@descript", MySqlDbType.MediumText)).Value = descript;
                command.Parameters.Add(new MySqlParameter("@pet_id", MySqlDbType.Bit)).Value = pet_num;
                command.Parameters.Add(new MySqlParameter("@staff_id", MySqlDbType.Int32)).Value = staff_num;
                command.Parameters.Add(new MySqlParameter("@admission", MySqlDbType.Bit)).Value = admin;
                command.Parameters.Add(new MySqlParameter("@pen_num", MySqlDbType.Bit)).Value = pen_num;

                reader = command.ExecuteReader();
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Pet Successfuly Registered!";
            }
            catch (Exception ex)
            {
                lblRegStatus.Text = "Pet Registration Unsuccessful: " + ex.Source +", "+ ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
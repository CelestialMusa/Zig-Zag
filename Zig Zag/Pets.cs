using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class Pets : Form
    {
        private string connectionstring = @"Data Source=196.253.61.51; Database=d25535935; User ID= root; Password='inteltechs'";
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        private string stateAdd = "active";
        private string stateRemove = "";

        public Pets()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionstring);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ViewPet child = new ViewPet();
            ActiveForm.Hide();
            child.Show();
        }

        private void Pets_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxAddUserBTN_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f04a(0)_2561.png");
            pictureBoxAddUserBTN.BackgroundImage = image;
            labelAdd.ForeColor = Color.FromArgb(254, 135, 25);
        }

        private void pictureBoxAddUserBTN_MouseLeave(object sender, EventArgs e)
        {
            if (stateAdd == "active")
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f04a(0)_256.png");
                pictureBoxAddUserBTN.BackgroundImage = image;
                labelAdd.ForeColor = Color.FromArgb(0, 85, 127);
            }
            else
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f081(0)_256.png");
                pictureBoxAddUserBTN.BackgroundImage = image;
                labelAdd.ForeColor = Color.FromArgb(254, 135, 25);
            }
        }

        private void pictureBoxRemoveUserBTN_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f081(0)_2561.png");
            pictureBoxRemoveUserBTN.BackgroundImage = image;
            labelRemove.ForeColor = Color.FromArgb(0, 85, 127);
        }

        private void pictureBoxRemoveUserBTN_MouseLeave(object sender, EventArgs e)
        {
            if (stateRemove == "active")
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f081(0)_2561.png");
                pictureBoxRemoveUserBTN.BackgroundImage = image;
                labelRemove.ForeColor = Color.FromArgb(0, 85, 127);
            }
            else
            {
                Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f081(0)_256.png");
                pictureBoxRemoveUserBTN.BackgroundImage = image;
                labelRemove.ForeColor = Color.FromArgb(254, 135, 25);
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

        private void Pets_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'd25535935DataSet23.pet' table. You can move, or remove it, as needed.
                this.petTableAdapter1.Fill(this.d25535935DataSet23.pet);

                // TODO: This line of code loads data into the 'd25535935DataSet24.pet_owner_details' table. You can move, or remove it, as needed.
                this.pet_owner_detailsTableAdapter1.Fill(this.d25535935DataSet24.pet_owner_details);
            }
            catch (ConstraintException)
            {
            }
            pictureBox5.Visible = true;
            cmbEditPet.Text = "";
            cmbEditPet.Enabled = false;
            pictureBoxAddUserBTN.Visible = true;
            labelAdd.Visible = true;
            cmbPetOwner.Text = "";
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

        private void pictureBoxGo_Click(object sender, EventArgs e)
        {
            string pname = txtPetName.Text;
            string ptype = cmbPetType.Text;
            string pdescript = txtPetDescript.Text;
            string dob = dtpPetDOB.Value.ToShortDateString();
            byte powner = (byte)cmbPetOwner.SelectedValue;

            if (radioButtonAddEmployee.Checked)
            {
                insertPet(pname, ptype, pdescript, dob, powner);
            }
            else if (radioButtonEditEmployee.Checked)
            {
                updatePet(pname, ptype, pdescript, dob, powner);
            }
        }

        private void radioButtonAddEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddEmployee.Checked)
            {
                cmbEditPet.Enabled = false;
                txtPetDescript.Text = "";
                txtPetName.Text = "";
                cmbEditPet.Text = "";
                cmbPetOwner.Text = "";
                dtpPetDOB.Text = "";
                cmbPetType.Text = "";
            }
        }

        private void radioButtonEditEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEditEmployee.Checked)
            {
                cmbEditPet.Enabled = true;
            }
        }

        private void insertPet(string pname, string ptype, string pdescript, string dob, int powner)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert_pet";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@pet_name", MySqlDbType.VarChar)).Value = pname;
                command.Parameters.Add(new MySqlParameter("@pet_type", MySqlDbType.MediumText)).Value = ptype;
                command.Parameters.Add(new MySqlParameter("@pet_descr", MySqlDbType.LongText)).Value = pdescript;
                command.Parameters.Add(new MySqlParameter("@pet_dob", MySqlDbType.Date)).Value = dob;
                command.Parameters.Add(new MySqlParameter("@owner_num", MySqlDbType.Bit)).Value = powner;

                reader = command.ExecuteReader();
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Pet Successfuly Registered!";
            }
            catch (Exception ex)
            {
                lblRegStatus.Text = "Pet Registration Unsuccessful: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        public void updatePet(string pname, string ptype, string pdescript, string dob, int powner)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "update_pet";
                command.CommandType = CommandType.StoredProcedure;

                byte pet_id = (byte)cmbEditPet.SelectedValue;

                command.Parameters.Add(new MySqlParameter("@pet_id", MySqlDbType.Bit)).Value = pet_id;
                command.Parameters.Add(new MySqlParameter("@pet_name", MySqlDbType.VarChar)).Value = pname;
                command.Parameters.Add(new MySqlParameter("@pet_type", MySqlDbType.MediumText)).Value = ptype;
                command.Parameters.Add(new MySqlParameter("@pet_descr", MySqlDbType.LongText)).Value = pdescript;
                command.Parameters.Add(new MySqlParameter("@pet_dob", MySqlDbType.Date)).Value = dob;
                command.Parameters.Add(new MySqlParameter("@owner_num", MySqlDbType.Bit)).Value = powner;

                reader = command.ExecuteReader();
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Pet Successfuly Updated!";
            }
            catch (Exception ex)
            {
                lblRegStatus.Text = "Pet Update Unsuccessful " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        private void cmbEditPet_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                byte pet_id = (byte)cmbEditPet.SelectedValue;
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "get_pet";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@pet_id", MySqlDbType.Int32)).Value = pet_id;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtPetName.Text = (reader["PET_NAME"].ToString());
                    cmbPetType.Text = (reader["PET_TYPE"].ToString());
                    txtPetDescript.Text = (reader["PET_DESCRIPTION"].ToString());
                    dtpPetDOB.Text = (reader["PET_DOB"].ToString());
                    cmbPetOwner.Text = (reader["OWNER_NAME"].ToString());
                }
            }
            catch (Exception ex)
            {
                lblRegStatus.Text = ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
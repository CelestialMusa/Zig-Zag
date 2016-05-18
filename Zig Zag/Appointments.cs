using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace Zig_Zag
{
    public partial class Appointments : Form
    {
        private string connectionstring = @"Data Source=196.253.61.51; Database=d25535935; User ID= root; Password='inteltechs'";
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private DataTable myDataTable;

        string pet_num;
        int index = 0;

        ArrayList arrPets = new ArrayList();

        private string stateAdd = "active";
        private string stateRemove = "";

        public Appointments()
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
            byte owner_num = (byte)cmbPetOwner.SelectedValue;
            string date = dtpAppoint.Value.ToShortDateString();
            string time = dtpTime.Value.Hour.ToString()+":"+ dtpTime.Value.Minute.ToString()+":"+dtpTime.Value.Second.ToString();
            string dateTime = date+" "+time;
            byte clinic = (byte) cmbClinic.SelectedValue;

            insertAppoint(owner_num, dateTime, clinic, pet_num);
        }

        public void insertAppoint(byte owner_num,string dateTime, byte clinic, string pet_id)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert_appointment";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@clinic", MySqlDbType.Bit)).Value = clinic;
                command.Parameters.Add(new MySqlParameter("@app_date", MySqlDbType.Timestamp)).Value = dateTime;
                command.Parameters.Add(new MySqlParameter("@pet", MySqlDbType.Bit)).Value = pet_id;
                command.Parameters.Add(new MySqlParameter("@owner_num", MySqlDbType.Bit)).Value = owner_num;

                reader = command.ExecuteReader();
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Appointment Successfully Registered!";
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

        private void Appointments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd25535935DataSet35.get_appointments' table. You can move, or remove it, as needed.
            try
            {
                this.get_appointmentsTableAdapter.Fill(this.d25535935DataSet35.get_appointments);
            }
            catch(Exception)
            {

            }
            finally
            {
                connection.Close();
            }
                // TODO: This line of code loads data into the 'd25535935DataSet30.get_all_pet_owners' table. You can move, or remove it, as needed.
            this.get_all_pet_ownersTableAdapter1.Fill(this.d25535935DataSet30.get_all_pet_owners);
            // TODO: This line of code loads data into the 'd25535935DataSet1.clinic_details' table. You can move, or remove it, as needed.
            this.clinic_detailsTableAdapter.Fill(this.d25535935DataSet1.clinic_details);

            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.ShowUpDown = true;

            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm:ss";

            cmbEditAppointment.Text = "";
            cmbEditAppointment.Enabled = false;
        }

        private void radioButtonAddAppointment_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonAddAppointment.Checked)
            {
                cmbEditAppointment.Enabled = false;
                cmbEditAppointment.Text = "";
            }
        }

        private void radioButtonEditAppointment_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonEditAppointment.Checked)
            {
                cmbEditAppointment.Enabled = true;
            }
        }

        private void cmbPetOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {  
                byte owner_num = (byte) cmbPetOwner.SelectedValue;
                loadPet(owner_num);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Source);           
            }
        }

        private void loadPet(byte owner_num)
        {    
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "get_owner_pets";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@owner_num", MySqlDbType.Bit)).Value = owner_num;

                reader = command.ExecuteReader();

                cmbPet.Items.Clear();

                while (reader.Read())
                {
                    cmbPet.Items.Add(new { PetID = reader["PET_ID"].ToString(), PetName = reader["PET_DESCRIPTION"].ToString() });
                    pet_num = reader["PET_ID"].ToString();
                    arrPets.Insert(index, pet_num);
                    index++;
                }
                index = 0;

                cmbPet.ValueMember = "PetID";
                cmbPet.DisplayMember = "PetName";
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
               // MessageBox.Show(ex.Message+" "+ex.Source);
            }
            finally
            {
                connection.Close();
            }
        }

        private void cmbEditAppointment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadAppointOwners();
            connection.Close();
        }

        private void loadAppointOwners()
        {
            try
            {
                byte owner_num = (byte)cmbEditAppointment.SelectedValue;

                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "get_appointment_owner";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@owner_num", MySqlDbType.Bit)).Value = owner_num;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbPetOwner.Text = (reader["OWNER_NAME"].ToString());
                    dtpAppoint.Text = (reader["APP_DATE"].ToString());
                    dtpTime.Text = (reader["APP_TIME"].ToString());
                    cmbClinic.Text = (reader["Clinic_address"].ToString());
                }
            }
            catch (Exception ex)
            {
                //lblRegStatus.Text = ex.Message + ex.Source;
            }
            finally
            {
                connection.Close();
            }
        }   
    }
}
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class Customers : Form
    {
        private string connectionstring = @"Data Source=196.253.61.51; Database=d25535935; User ID= root; Password='inteltechs'";
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private DataTable myDataTable;

        public Customers()
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

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            SystemWin child = new SystemWin();
            ActiveForm.Hide();
            child.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ViewCustomer child = new ViewCustomer();
            ActiveForm.Hide();
            child.Show();
        }

        private void Customers_ForeColorChanged(object sender, EventArgs e)
        {
        }

        private void Customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(106, 75);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(770, 347);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0a9(0)_2561.png");
            pictureBox4.BackgroundImage = image;
            labelNext.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(96, 65);
            pictureBox4.Size = size;
            pictureBox4.Location = new Point(776, 349);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\FontAwesome_f0a9(0)_256.png");
            pictureBox4.BackgroundImage = image;
            labelNext.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            txtPetname.Focus();
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

        private void radioButtonAddEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddPetOwner.Checked)
            {
                comboBoxEditPetOwner.Enabled = false;
                txtFirst.Text = "";
                txtCity.Text = "";
                txtID.Text = "";
                txtLast.Text = "";
                txtPetDescript.Text = "";
                txtPetname.Text = "";
                txtState.Text = "";
                txtStreet.Text = "";
                txtTel.Text = "";
                txtZip.Text = "";
                cmbClinic.Text = "";
                cmbGender.Text = "";
                cmbPetType.Text = "";
            }
        }

        private void radioButtonEditPetOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEditPetOwner.Checked)
            {
                comboBoxEditPetOwner.Enabled = true;
                comboBoxEditPetOwner.Text = comboBoxEditPetOwner.SelectedText;
            }
        }

        private void loadDetails()
        {
            try
            {
                byte owner_num = (byte)comboBoxEditPetOwner.SelectedValue;
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "get_owner";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@owner_num", MySqlDbType.Int32)).Value = owner_num;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtFirst.Text = (reader["FIRST_NAME"].ToString());
                    txtLast.Text = (reader["LAST_NAME"].ToString());
                    cmbGender.Text = (reader["Gender"].ToString());
                    dtPicker.Text = (reader["DOB"].ToString());
                    txtTel.Text = (reader["TELEPHONE"].ToString());
                    txtID.Text = (reader["ID_NO"].ToString());
                    cmbClinic.Text = (reader["Clinic_address"].ToString());
                    txtPetname.Text = (reader["PET_NAME"].ToString());
                    txtPetDescript.Text = (reader["PET_DESCRIPTION"].ToString());
                    cmbPetType.Text = (reader["STATE"].ToString());
                    dtpPetDOB.Text = (reader["PET_DOB"].ToString());
                    txtState.Text = (reader["STATE"].ToString());
                    txtZip.Text = (reader["ZIPCODE"].ToString());
                    txtCity.Text = (reader["CITY"].ToString());
                    txtStreet.Text = (reader["STREET"].ToString());
                }

                if (cmbGender.Text == "1")
                {
                    cmbGender.Text = "Male";
                }
                else
                    cmbGender.Text = "Female";
            }
            catch (Exception ex)
            {
                lblRegStatus.Text= ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        private void comboBoxEditPetOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDetails();
        }

        private void pictureBoxGo_Click(object sender, EventArgs e)
        {
            string fname = txtFirst.Text;
            string lname = txtLast.Text;
            string tel = txtTel.Text;
            string id_no = txtID.Text;
            string gender = cmbGender.Text;
            if (gender == "Male")
            {
                gender = "1";
            }
            else if (gender == "Female")
            {
                gender = "0";
            }
            string dob = dtPicker.Value.ToShortDateString();
            byte clinic_id = (byte)cmbClinic.SelectedValue;
            string pname = txtPetname.Text;
            string pdescript = txtPetDescript.Text;
            string petType = cmbPetType.Text;
            string petDOB = dtpPetDOB.Value.ToShortDateString();
            string street = txtState.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zip = txtZip.Text;

            if (radioButtonAddPetOwner.Checked)
            {
                insertOwner(fname, lname, tel, id_no, gender, dob, clinic_id, pname, petType, pdescript, petDOB, street, city, state, zip);
            }
            else if (radioButtonEditPetOwner.Checked)
            {
                byte owner_num = (byte)comboBoxEditPetOwner.SelectedValue;
                updatePetOwner(owner_num, fname, lname, tel, id_no, gender, dob, clinic_id, pname, petType, pdescript, petDOB, street, city, state, zip);
            }
        }

        private void insertOwner(string fname, string lname, string tel, string id_no, string gender, string dob, byte clinic_id,
                                string pname, string petType, string pdescript, string petDOB, string street, string city, string state, string zip)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert_pet_owner";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@street", MySqlDbType.VarChar)).Value = street;
                command.Parameters.Add(new MySqlParameter("@city", MySqlDbType.VarChar)).Value = city;
                command.Parameters.Add(new MySqlParameter("@state", MySqlDbType.VarChar)).Value = state;
                command.Parameters.Add(new MySqlParameter("@zipcode", MySqlDbType.VarChar)).Value = zip;
                command.Parameters.Add(new MySqlParameter("@first_name", MySqlDbType.VarChar)).Value = fname;
                command.Parameters.Add(new MySqlParameter("@last_name", MySqlDbType.VarChar)).Value = lname;
                command.Parameters.Add(new MySqlParameter("@tel", MySqlDbType.VarChar)).Value = tel;
                command.Parameters.Add(new MySqlParameter("@id_no", MySqlDbType.VarChar)).Value = id_no;
                command.Parameters.Add(new MySqlParameter("@gender", MySqlDbType.Bit)).Value = gender;
                command.Parameters.Add(new MySqlParameter("@dob", MySqlDbType.Date)).Value = dob;
                command.Parameters.Add(new MySqlParameter("@clinic", MySqlDbType.Bit)).Value = clinic_id;
                command.Parameters.Add(new MySqlParameter("@pet_name", MySqlDbType.VarChar)).Value = pname;
                command.Parameters.Add(new MySqlParameter("@pet_type", MySqlDbType.MediumText)).Value = petType;
                command.Parameters.Add(new MySqlParameter("@pet_descript", MySqlDbType.LongText)).Value = pdescript;
                command.Parameters.Add(new MySqlParameter("@pet_dob", MySqlDbType.Date)).Value = petDOB;

                reader = command.ExecuteReader();
                myDataTable.Load(reader);
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Pet Owner Successfuly Inserted!";
            }
            catch (Exception ex)
            {
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Pet Owner Insertion unsuccessful: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        private void updatePetOwner(byte owner_num, string fname, string lname, string tel, string id_no, string gender, string dob, byte clinic_id,
                                string pname, string petType, string pdescript, string petDOB, string street, string city, string state, string zip)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "update_pet_owner";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@owner_num", MySqlDbType.Bit)).Value = owner_num;
                command.Parameters.Add(new MySqlParameter("@street", MySqlDbType.VarChar)).Value = street;
                command.Parameters.Add(new MySqlParameter("@city", MySqlDbType.VarChar)).Value = city;
                command.Parameters.Add(new MySqlParameter("@state", MySqlDbType.VarChar)).Value = state;
                command.Parameters.Add(new MySqlParameter("@zipcode", MySqlDbType.VarChar)).Value = zip;
                command.Parameters.Add(new MySqlParameter("@first_name", MySqlDbType.VarChar)).Value = fname;
                command.Parameters.Add(new MySqlParameter("@last_name", MySqlDbType.VarChar)).Value = lname;
                command.Parameters.Add(new MySqlParameter("@tel", MySqlDbType.VarChar)).Value = tel;
                command.Parameters.Add(new MySqlParameter("@id_no", MySqlDbType.VarChar)).Value = id_no;
                command.Parameters.Add(new MySqlParameter("@gender", MySqlDbType.Bit)).Value = gender;
                command.Parameters.Add(new MySqlParameter("@dob", MySqlDbType.Date)).Value = dob;
                command.Parameters.Add(new MySqlParameter("@clinic", MySqlDbType.Bit)).Value = clinic_id;
                command.Parameters.Add(new MySqlParameter("@pet_name", MySqlDbType.VarChar)).Value = pname;
                command.Parameters.Add(new MySqlParameter("@pet_type", MySqlDbType.MediumText)).Value = petType;
                command.Parameters.Add(new MySqlParameter("@pet_descript", MySqlDbType.LongText)).Value = pdescript;
                command.Parameters.Add(new MySqlParameter("@pet_dob", MySqlDbType.Date)).Value = petDOB;

                reader = command.ExecuteReader();
                myDataTable.Load(reader);
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Pet Owner Successfuly Updated!";
            }
            catch (Exception ex)
            {
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Pet Owner Updating unsuccessful: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd25535935DataSet19.clinic_details' table. You can move, or remove it, as needed.
            this.clinic_detailsTableAdapter.Fill(this.d25535935DataSet19.clinic_details);
            // TODO: This line of code loads data into the 'd25535935DataSet18.pet_owner_details' table. You can move, or remove it, as needed.
            this.pet_owner_detailsTableAdapter.Fill(this.d25535935DataSet18.pet_owner_details);
            comboBoxEditPetOwner.Enabled = false;
            comboBoxEditPetOwner.Text = "";
            cmbClinic.Text = "";
            txtFirst.Focus();
        }
    }
}
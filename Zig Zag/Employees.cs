using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Zig_Zag
{
    public partial class Employees : Form
    {
        string connectionstring = @"Data Source=196.253.61.51; Database=d25535935; User ID= root; Password='inteltechs'";
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        DataTable myDataTable;

        string stateAdd = "active";
        string stateRemove = "";
        
        public Employees()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionstring);
            myDataTable = new DataTable();
            comboBoxEditEmployee.Enabled = false;
            label29.Visible= false;
            lblR1.Visible = false;
            lblR2.Visible = false;
            lblR3.Visible = false;
            lblR4.Visible = false;
            lblR5.Visible = false;
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

        private void Employees_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(106, 75);
            pictureBoxGo.Size = size;
            pictureBoxGo.Location = new Point(770, 347);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_256.png");
            pictureBoxGo.BackgroundImage = image;
            labelSubmit.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(96, 65);
            pictureBoxGo.Size = size;
            pictureBoxGo.Location = new Point(776, 349);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_2561.png");
            pictureBoxGo.BackgroundImage = image;
            labelSubmit.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblRegStatus.Visible = false;
            tabControl1.SelectedTab = tabPage2;
        }

        private void radioButtonAddEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAddEmployee.Checked == true)
            {
                comboBoxEditEmployee.Enabled = false;
                comboBoxEditEmployee.Text = "";
                textBox1State.Text = "";
                textBoxLastName.Text = "";
                textBoxFirstName.Text = "";
                comboBoxGender.Text = "";
                dateTimePickerDateOfBirth.Text = "";
                textBoxSalary.Text = "";
                textBoxZipCode.Text = "";
                textBoxStreet.Text = "";
                textBoxCity.Text = "";
                comboBoxJobDescription.Text = "";
                textBoxIDNumber.Text = "";
                comboBoxClinicID.Text = "";
                textBoxTelephone.Text = "";
            }
        }

        private void pictureBoxGo_Click(object sender, EventArgs e)
        {
                string name = textBoxFirstName.Text;
                string last = textBoxLastName.Text;
                string gender;
                if (comboBoxGender.SelectedText == "Male")
                {
                    gender = "1";
                }
                else
                {
                    gender = "0";
                }
                string dob = dateTimePickerDateOfBirth.Value.ToShortDateString();
                string tel = textBoxTelephone.Text;
                string id = textBoxIDNumber.Text;
                int job = (int)comboBoxJobDescription.SelectedValue;
                string salary = textBoxSalary.Text;
                byte clinic_id = (byte)comboBoxClinicID.SelectedValue;
                string state = textBox1State.Text;
                string city = textBoxCity.Text;
                string street = textBoxStreet.Text;
                string zip = textBoxZipCode.Text;

            if(radioButtonAddEmployee.Checked)
            {
                insert_staff(name, last, gender, dob, tel, id, job, salary, clinic_id, state, city, street, zip);
            }
            else if(radioButtonEditEmployee.Checked)
            {
                int staff_num = (int) comboBoxEditEmployee.SelectedValue;
                update_employee(staff_num,name, last, gender, dob, tel, id, job, salary, clinic_id, state, city, street, zip);
            }
                
        }

        private void update_employee(int staff_num,string name, string last, string gender, string dob, string tel,
                                    string id, int job, string salary, byte clinic_id, string state,
                                    string city, string street, string zip)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "update_staff";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@staff_num", MySqlDbType.Int32)).Value = staff_num;
                command.Parameters.Add(new MySqlParameter("@street", MySqlDbType.VarChar)).Value = street;
                command.Parameters.Add(new MySqlParameter("@city", MySqlDbType.VarChar)).Value = city;
                command.Parameters.Add(new MySqlParameter("@state", MySqlDbType.VarChar)).Value = state;
                command.Parameters.Add(new MySqlParameter("@zipcode", MySqlDbType.VarChar)).Value = zip;
                command.Parameters.Add(new MySqlParameter("@first_name", MySqlDbType.VarChar)).Value = name;
                command.Parameters.Add(new MySqlParameter("@last_name", MySqlDbType.VarChar)).Value = last;
                command.Parameters.Add(new MySqlParameter("@id_no", MySqlDbType.VarChar)).Value = id;
                command.Parameters.Add(new MySqlParameter("@dob", MySqlDbType.Date)).Value = dob;
                command.Parameters.Add(new MySqlParameter("@gender", MySqlDbType.Bit)).Value = gender;
                command.Parameters.Add(new MySqlParameter("@job_code", MySqlDbType.Int32)).Value = job;
                command.Parameters.Add(new MySqlParameter("@annual_sal", MySqlDbType.Double)).Value = salary;
                command.Parameters.Add(new MySqlParameter("@clinic_id", MySqlDbType.Int32)).Value = clinic_id;
                command.Parameters.Add(new MySqlParameter("@tel", MySqlDbType.VarChar)).Value = tel;

                reader = command.ExecuteReader();
                myDataTable.Load(reader);
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Employee Successfuly Updated.";
            }
            catch (Exception ex)
            {
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Employee Updating unsuccessful: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        private void insert_staff(string name,string last,string gender,string dob,string tel,
                                    string id,int job,string salary, byte clinic_id,string state,
                                    string city,string street,string zip)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert_staff";
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.Add(new MySqlParameter("@street", MySqlDbType.VarChar)).Value = street;
                command.Parameters.Add(new MySqlParameter("@city", MySqlDbType.VarChar)).Value = city;
                command.Parameters.Add(new MySqlParameter("@state", MySqlDbType.VarChar)).Value = state;
                command.Parameters.Add(new MySqlParameter("@zipcode", MySqlDbType.VarChar)).Value = zip;
                command.Parameters.Add(new MySqlParameter("@first_name", MySqlDbType.VarChar)).Value = name;
                command.Parameters.Add(new MySqlParameter("@last_name", MySqlDbType.VarChar)).Value = last;
                command.Parameters.Add(new MySqlParameter("@id_no", MySqlDbType.VarChar)).Value = id;
                command.Parameters.Add(new MySqlParameter("@dob", MySqlDbType.Date)).Value = dob;
                command.Parameters.Add(new MySqlParameter("@gender", MySqlDbType.Bit)).Value = gender;
                command.Parameters.Add(new MySqlParameter("@job_code", MySqlDbType.Int32)).Value = job;
                command.Parameters.Add(new MySqlParameter("@annual_sal", MySqlDbType.Double)).Value = salary;
                command.Parameters.Add(new MySqlParameter("@clinic_id", MySqlDbType.Int32)).Value = clinic_id;
                command.Parameters.Add(new MySqlParameter("@tel", MySqlDbType.VarChar)).Value = tel;

                reader = command.ExecuteReader();
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Employee Successfuly Registered.";
            }
            catch (Exception ex)
            {
                lblRegStatus.Visible = true;
                lblRegStatus.Text = "Employee Registration unsuccessful: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        private void radioButtonEditEmployee_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEditEmployee.Checked == true)
            {
                comboBoxEditEmployee.Enabled = true;
                //loadCombo();
            }
        }

        private void comboBoxEditEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void loadCombo()
        {
            try
            {
                int staff_num = (int)comboBoxEditEmployee.SelectedValue;
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "get_employee";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new MySqlParameter("@staff_num", MySqlDbType.Int32)).Value = staff_num;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    textBoxFirstName.Text = (reader["FIRST_NAME"].ToString());
                    textBoxLastName.Text = (reader["LAST_NAME"].ToString());
                    comboBoxGender.Text = (reader["Gender"].ToString());
                    dateTimePickerDateOfBirth.Text = (reader["DOB"].ToString());
                    textBoxTelephone.Text = (reader["TELEPHONE"].ToString());
                    textBoxIDNumber.Text = (reader["ID_NO"].ToString());
                    comboBoxJobDescription.Text = (reader["JOB_DESCRIPTION"].ToString());
                    textBoxSalary.Text = (reader["ANNUAL_SALARY"].ToString());
                    comboBoxClinicID.Text = (reader["Clini_address"].ToString());
                    textBox1State.Text = (reader["STATE"].ToString());
                    textBoxCity.Text = (reader["CITY"].ToString());
                    textBoxStreet.Text = (reader["STREET"].ToString());
                    textBoxZipCode.Text = (reader["ZIPCODE"].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        private void comboBoxDeleteEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int staff_num = (int)comboBoxDeleteEmployee.SelectedValue;
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "get_employee";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@staff_num", MySqlDbType.Int32)).Value = staff_num;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    textBoxDeleteEmployeeFName.Text = (reader["FIRST_NAME"].ToString());
                    textBoxDeleteEmployeeLName.Text = (reader["LAST_NAME"].ToString());
                    comboBox2.Text = (reader["Gender"].ToString());
                    textBox2.Text = (reader["TELEPHONE"].ToString());
                    textBox1.Text = (reader["ID_NO"].ToString());
                    comboBox1.Text = (reader["JOB_DESCRIPTION"].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBoxRemoveUserGo_Click(object sender, EventArgs e)
        {
            try
            {
                int staff_num = (int)comboBoxDeleteEmployee.SelectedValue;
                
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "delete_staff";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@staff_num", MySqlDbType.Int32)).Value = staff_num;

                reader = command.ExecuteReader();
                lblStatus.Text = "Employee Successfully Deleted!";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Deletion Error: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBoxRemoveUserGo_MouseMove(object sender, MouseEventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_256.png");
            pictureBoxRemoveUserGo.BackgroundImage = image;
        }

        private void pictureBoxRemoveUserGo_MouseLeave(object sender, EventArgs e)
        {
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\linecons_e01a(0)_2561.png");
            pictureBoxRemoveUserGo.BackgroundImage = image;
        }

        private void pictureBox5_MouseMove_1(object sender, MouseEventArgs e)
        {
            Size size = new Size(106, 75);
            pictureBox5.Size = size;
            pictureBox5.Location = new Point(889,69);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\et-line_e006(0)_2561.png");
            pictureBox5.BackgroundImage = image;
            labelViewAll.Visible = true;
        }

        private void pictureBox5_MouseLeave_1(object sender, EventArgs e)
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
            ViewEmployees child = new ViewEmployees();
            ActiveForm.Hide();
            child.Show();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd25535935DataSet17.list_staff_members' table. You can move, or remove it, as needed.
            this.list_staff_membersTableAdapter.Fill(this.d25535935DataSet17.list_staff_members);
            // TODO: This line of code loads data into the 'd25535935DataSet16.clinic_details' table. You can move, or remove it, as needed.
            this.clinic_detailsTableAdapter.Fill(this.d25535935DataSet16.clinic_details);
            // TODO: This line of code loads data into the 'd25535935DataSet15.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.d25535935DataSet15.job);

            comboBoxEditEmployee.Enabled = false;
            comboBoxEditEmployee.Text = "";
            comboBoxClinicID.Text = "";
            
        } 
    }
}

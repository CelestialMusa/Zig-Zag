using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace Zig_Zag
{
    public partial class Examinations : Form
    {
        private string connectionstring = @"Data Source=196.253.61.51; Database=d25535935; User ID= root; Password='inteltechs'";
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private DataTable myDataTable;

        string pet_num;
        string pen_num;

        ArrayList arrPets = new ArrayList();
        ArrayList arrPens = new ArrayList();

        int index = 0;

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
            // TODO: This line of code loads data into the 'd25535935DataSet36.get_examination' table. You can move, or remove it, as needed.
            this.get_examinationTableAdapter.Fill(this.d25535935DataSet36.get_examination);
            // TODO: This line of code loads data into the 'd25535935DataSet25.get_medical_staff' table. You can move, or remove it, as needed.
            this.get_medical_staffTableAdapter.Fill(this.d25535935DataSet25.get_medical_staff);
            // TODO: This line of code loads data into the 'd25535935DataSet21.treatment_type' table. You can move, or remove it, as needed.
            this.treatment_typeTableAdapter.Fill(this.d25535935DataSet21.treatment_type);
            // TODO: This line of code loads data into the 'd25535935DataSet20.pet' table. You can move, or remove it, as needed.
            this.petTableAdapter.Fill(this.d25535935DataSet20.pet);
            // TODO: This line of code loads data into the 'd25535935DataSet17.list_staff_members' table. You can move, or remove it, as needed.
            this.list_staff_membersTableAdapter.Fill(this.d25535935DataSet17.list_staff_members);
            lblDisplay.Visible = true;
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

        private void loadsPets(int staff_num)
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
                    pet_num = reader["PET_ID"].ToString();
                    arrPets.Add(pet_num);
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
                    pen_num = reader["PEN_NUM"].ToString();
                    arrPens.Insert(index, pen_num);
                    index++;
                }
                index = 0;
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

            int staff_num =  (int) cmbStaff.SelectedValue;
            string admin = cmbAdmin.SelectedText;
            
            if(admin=="Yes")
            {
                admin = "1";
            }
            else
            {
                admin = "0";
            }

            string pen = arrPens[cmbPens.SelectedIndex].ToString();
            string pet = arrPets[cmbPets.SelectedIndex].ToString();

            insertExam(descript, pet, staff_num, admin, pen);
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
                lblRegStatus.Text = "Pet Examination Successfully Completed!";
            }
            catch (Exception ex)
            {
                lblRegStatus.Text = "Pet Examination Could Not Be Complete: " + ex.Source +", "+ ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            byte exam_num = (byte)cmbExamination.SelectedValue;
            byte treatment = (byte)cmbTreatments.SelectedValue;
            string begin_date = (string)dtpBegin.Value.ToShortDateString();
            string end_date = (string)dtpEnd.Value.ToShortDateString();
            int qty = Convert.ToInt32(cmbQty.SelectedItem);
            string comments = txtComment.Text;

            insertTreatment(treatment, begin_date, end_date, qty, comments,exam_num);
        }

        private void insertTreatment(byte treatment,string begin_date,string end_date,int qty,string comments,byte exam_num)
        {
            try
            {
                connection.Open();
                command = new MySqlCommand();
                command.Connection = connection;
                command.CommandText = "insert_suggested_treatments_for_exam";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new MySqlParameter("@date_begin", MySqlDbType.Timestamp)).Value = begin_date;
                command.Parameters.Add(new MySqlParameter("@date_end", MySqlDbType.Date)).Value = end_date;
                command.Parameters.Add(new MySqlParameter("@exam_id", MySqlDbType.Bit)).Value = exam_num;
                command.Parameters.Add(new MySqlParameter("@treatment_id", MySqlDbType.Bit)).Value = treatment;
                command.Parameters.Add(new MySqlParameter("@treat_qty", MySqlDbType.Int32)).Value = qty;
                command.Parameters.Add(new MySqlParameter("@treat_comments", MySqlDbType.VarBinary)).Value = comments;

                reader = command.ExecuteReader();
                lblDisplay.Visible = true;
                lblDisplay.Text = "Pet Treatment Successfully Proposed!";
            }
            catch (Exception ex)
            {
                lblDisplay.Text = "Pet Treatment Could Not Be Complete: " + ex.Source + ", " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
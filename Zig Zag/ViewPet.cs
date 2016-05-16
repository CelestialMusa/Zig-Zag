using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zig_Zag
{
    public partial class ViewPet : Form
    {
        public ViewPet()
        {
            InitializeComponent();
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Pets child = new Pets();
            ActiveForm.Hide();
            child.Show();
        }

        private void ViewPet_FormClosed(object sender, FormClosedEventArgs e)
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

        private void pictureBoxPetOwnedBy_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxPetOwnedBy.Size = size;
            Size size2 = new Size(530, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(119, 455);
            pictureBoxPetOwnedBy.Location = new Point(343, 558);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f018(0)_256.png");
            pictureBoxPetOwnedBy.BackgroundImage = image;
            labelSystem.Text = "List pet details owned by";
            labelSystem.Location = new Point(126, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
            comboBoxOwnerNumOwners.Visible = true;
            radioButtonAnsOwner.Visible = true;
            radioButtonSpecOwner.Visible = true;
        }

        private void pictureBoxPetOwnedBy_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxPetOwnedBy.Size = size;
            pictureBoxPetOwnedBy.Location = new Point(352, 560);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f018(0)_2561.png");
            pictureBoxPetOwnedBy.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
            //labelSystem.Visible = false;
        }

        private void pictureBoxPetHistoricExam_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxPetHistoricExam.Size = size;
            Size size2 = new Size(620, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(38, 455);
            pictureBoxPetHistoricExam.Location = new Point(470, 570);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f064(0)_256.png");
            pictureBoxPetHistoricExam.BackgroundImage = image;
            labelSystem.Text = "View Pets Historic examinations";
            labelSystem.Location = new Point(45, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
            comboBoxOwnerNumOwners.Visible = true;
            radioButtonAnsOwner.Visible = true;
            radioButtonSpecOwner.Visible = true;
        }

        private void pictureBoxPetHistoricExam_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxPetHistoricExam.Size = size;
            pictureBoxPetHistoricExam.Location = new Point(479, 572);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f064(0)_2561.png");
            pictureBoxPetHistoricExam.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
            //labelSystem.Visible = false;
        }

        private void pictureBoxTotNumPetsPerType_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxTotNumPetsPerType.Size = size;
            Size size2 = new Size(530, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(119, 455);
            pictureBoxTotNumPetsPerType.Location = new Point(612, 572);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f016(0)_2561.png");
            pictureBoxTotNumPetsPerType.BackgroundImage = image;
            labelSystem.Text = "View Total pets for Type";
            labelSystem.Location = new Point(126, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
            comboBoxOwnerNumOwners.Visible = true;
            radioButtonAnsOwner.Visible = true;
            radioButtonSpecOwner.Visible = true;
        }

        private void pictureBoxTotNumPetsPerType_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxTotNumPetsPerType.Size = size;
            pictureBoxTotNumPetsPerType.Location = new Point(612, 572);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\octicons_f016(0)_256.png");
            pictureBoxTotNumPetsPerType.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
            //labelSystem.Visible = false;
        }

        private void pictureBoxUnpaidInvoicePet_MouseMove(object sender, MouseEventArgs e)
        {
            Size size = new Size(110, 87);
            pictureBoxUnpaidInvoicePet.Size = size;
            Size size2 = new Size(465, 1);
            pictureBox1.Size = size2;
            pictureBox1.Location = new Point(190, 455);
            pictureBoxUnpaidInvoicePet.Location = new Point(734, 570);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e034(0)_256.png");
            pictureBoxUnpaidInvoicePet.BackgroundImage = image;
            labelSystem.Text = "Unpaid invoices for";
            labelSystem.Location = new Point(200, 417);
            labelSystem.ForeColor = Color.FromArgb(255, 135, 25);
            pictureBoxSystemLine.BackColor = Color.FromArgb(0, 85, 127);
            comboBoxOwnerNumOwners.Visible = true;
            radioButtonAnsOwner.Visible = false;
            radioButtonSpecOwner.Visible = false;
        }

        private void pictureBoxUnpaidInvoicePet_MouseLeave(object sender, EventArgs e)
        {
            Size size = new Size(100, 77);
            pictureBoxUnpaidInvoicePet.Size = size;
            pictureBoxUnpaidInvoicePet.Location = new Point(743, 572);
            Image image = Image.FromFile("C:\\IntelTechs\\resources\\Typicons_e034(0)_2561.png");
            pictureBoxUnpaidInvoicePet.BackgroundImage = image;
            labelSystem.ForeColor = Color.FromArgb(0, 85, 127);
            pictureBoxSystemLine.BackColor = Color.FromArgb(255, 135, 25);
            //labelSystem.Visible = false;
        }

        private void ViewPet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'd25535935DataSet7._total_num_of_pets_in_each_type' table. You can move, or remove it, as needed.
            this.total_num_of_pets_in_each_typeTableAdapter.Fill(this.d25535935DataSet7._total_num_of_pets_in_each_type);
            // TODO: This line of code loads data into the 'd25535935DataSet6.pet_historical_exams' table. You can move, or remove it, as needed.
            this.pet_historical_examsTableAdapter.Fill(this.d25535935DataSet6.pet_historical_exams);
            // TODO: This line of code loads data into the 'd25535935DataSet5.list_pet_details_owned_by' table. You can move, or remove it, as needed.
            this.list_pet_details_owned_byTableAdapter.Fill(this.d25535935DataSet5.list_pet_details_owned_by);
        }

        private void pictureBoxPetOwnedBy_Click(object sender, EventArgs e)
        {
            if (radioButtonAnsOwner.Checked)
            {
                dataGridViewListPetDetailsOwnedBySpecified.Visible = false;
                dataGridViewPetExamHistoryUnspecified.Visible = false;
                dataGridViewPetExamHistorySpecified.Visible = false;
                dataGridViewListPetDetailsOwnedByUnspecified.Visible = true;
                dataGridViewdataGridViewTotNumPetsPerTypeUnspecified.Visible = false;
                dataGridViewTotNumPetsPerTypeSpecified.Visible = false;
                dataGridViewdataGridViewUnpaidInvoicePetSpecified.Visible = false;
            }
            if (radioButtonSpecOwner.Checked)
            {
                dataGridViewListPetDetailsOwnedBySpecified.Visible = true;
                dataGridViewPetExamHistoryUnspecified.Visible = false;
                dataGridViewPetExamHistorySpecified.Visible = false;
                dataGridViewListPetDetailsOwnedByUnspecified.Visible = false;
                dataGridViewdataGridViewTotNumPetsPerTypeUnspecified.Visible = false;
                dataGridViewTotNumPetsPerTypeSpecified.Visible = false;
                dataGridViewdataGridViewUnpaidInvoicePetSpecified.Visible = false;
            }
        }

        private void pictureBoxPetHistoricExam_Click(object sender, EventArgs e)
        {
            if (radioButtonAnsOwner.Checked)
            {
                dataGridViewListPetDetailsOwnedBySpecified.Visible = false;
                dataGridViewPetExamHistoryUnspecified.Visible = true;
                dataGridViewPetExamHistorySpecified.Visible = false;
                dataGridViewListPetDetailsOwnedByUnspecified.Visible = false;
                dataGridViewdataGridViewTotNumPetsPerTypeUnspecified.Visible = false;
                dataGridViewTotNumPetsPerTypeSpecified.Visible = false;
                dataGridViewdataGridViewUnpaidInvoicePetSpecified.Visible = false;
            }
            if (radioButtonSpecOwner.Checked)
            {
                dataGridViewListPetDetailsOwnedBySpecified.Visible = false;
                dataGridViewPetExamHistoryUnspecified.Visible = false;
                dataGridViewPetExamHistorySpecified.Visible = true;
                dataGridViewListPetDetailsOwnedByUnspecified.Visible = false;
                dataGridViewdataGridViewTotNumPetsPerTypeUnspecified.Visible = false;
                dataGridViewTotNumPetsPerTypeSpecified.Visible = false;
                dataGridViewdataGridViewUnpaidInvoicePetSpecified.Visible = false;
            }
        }

        private void pictureBoxTotNumPetsPerType_Click(object sender, EventArgs e)
        {
            if (radioButtonAnsOwner.Checked)
            {
                dataGridViewListPetDetailsOwnedBySpecified.Visible = false;
                dataGridViewPetExamHistoryUnspecified.Visible = false;
                dataGridViewPetExamHistorySpecified.Visible = false;
                dataGridViewListPetDetailsOwnedByUnspecified.Visible = false;
                dataGridViewdataGridViewTotNumPetsPerTypeUnspecified.Visible = true;
                dataGridViewTotNumPetsPerTypeSpecified.Visible = false;
                dataGridViewdataGridViewUnpaidInvoicePetSpecified.Visible = false;
            }
            if (radioButtonSpecOwner.Checked)
            {
                dataGridViewListPetDetailsOwnedBySpecified.Visible = false;
                dataGridViewPetExamHistoryUnspecified.Visible = false;
                dataGridViewPetExamHistorySpecified.Visible = false;
                dataGridViewListPetDetailsOwnedByUnspecified.Visible = false;
                dataGridViewdataGridViewTotNumPetsPerTypeUnspecified.Visible = false;
                dataGridViewTotNumPetsPerTypeSpecified.Visible = true;
                dataGridViewdataGridViewUnpaidInvoicePetSpecified.Visible = false;
            }
        }

        private void pictureBoxUnpaidInvoicePet_Click(object sender, EventArgs e)
        {
            dataGridViewListPetDetailsOwnedBySpecified.Visible = false;
            dataGridViewPetExamHistoryUnspecified.Visible = false;
            dataGridViewPetExamHistorySpecified.Visible = false;
            dataGridViewListPetDetailsOwnedByUnspecified.Visible = false;
            dataGridViewdataGridViewTotNumPetsPerTypeUnspecified.Visible = false;
            dataGridViewTotNumPetsPerTypeSpecified.Visible = false;
            dataGridViewdataGridViewUnpaidInvoicePetSpecified.Visible = true;
        }
    }
}
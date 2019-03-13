using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomRservation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlHome.BringToFront();
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            pnlAvailbility.BringToFront();
        }
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlHome.BringToFront();
        }

     
        private void btnBooking_Click(object sender, EventArgs e)
        {
            pnlBookingForm.BringToFront();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ContactClass c = new ContactClass();
            //c.ContactID = Int32.Parse(txtboxContactID.Text);
            c.FirstName = txtboxFirstName.Text;
            c.LastName = txtboxLastName.Text;
            c.ContactNo = txtboxContactNumber.Text;
            c.Address = txtboxAddress.Text;
            String gender = "";

            if (radioMale.Checked)
            {
                gender = "Male";
            }else if (radioFemale.Checked)
            {
                gender = "Female";
                              
            }

            c.Gender = gender;
            c.DateOfBirth = dob.Value.ToShortDateString();
            c.RoomType = cmbRoomType.Text;
            c.Room = cmbRoom.Text;

            c.InsertCustomer();


        }
    }
}

using contacts_crud_demoo_new.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TooSharp.Core;
using TooSharp.Models;

namespace contacts_crud_demoo_new
{
    public partial class FormAddEditContact : Form
    {
        String Course1 = "";
        int currentage;
        private bool isCollapsed = true;

        Contact Contact = null;
        public FormAddEditContact()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            lblTitle.Text = "Add New Student";
            PnlError.Visible = false;
        }

        public FormAddEditContact(Contact contact)
        {

            InitializeComponent();
            radioButton1.Checked = true;
            if (contact.Gender.Equals("M"))
            {
                radioButton1.Checked = true;

            }
            else
            {
                radioButton2.Checked = true;
            }
            PnlError.Visible = false;
            btn1.Text = "Update";
            btn2.Visible = true;
            Contact = contact;
            lblTitle.Text = "Update Contact";
            contact.onValidationError += Contact_onValidationError;
            txtRegID.Text = contact.Reg_id.ToString();
            txtSName.Text = contact.S_name;
            dateTime.Text = contact.Dob.ToString();
            //txtGender.Text = contact.Gender;
            txtMobile.Text = contact.Mobile;
            button1.Text = contact.Course;


        }

        void showError(string Text)
        {
            LblEroor.Text = Text;
            PnlError.Visible = true;
            tmrError.Start();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void label5_Click(object sender, EventArgs e)
        {
                       
        }

        private void LblEroor_Click(object sender, EventArgs e)
        {

        }

        private void tmrError_Tick(object sender, EventArgs e)
        {

            tmrError.Stop();
            PnlError.Visible = false;

        }

        //create and update

        private void btn1_Click(object sender, EventArgs e)
        {
            if(currentage < 18)
            {
                showError("Cannot Enroll - Below 18 Years");
                return;

            }
            
            if (Contact == null)
            {
                String Gender = "";

                if (radioButton1.Checked == true)
                {
                    Gender = "M";

                }
                else if(radioButton2.Checked == true)
                {
                    Gender = "F";
                }
                else
                {
                    showError("Select Gender ");
                    return;
                }
              
                //new Contact
                try
                {

                    Contact contact = new Contact()
                    {
                        Reg_id = Int32.Parse(txtRegID.Text),
                        S_name = txtSName.Text,
                        Dob = dateTime.Text,
                        Gender = Gender,
                        Mobile = txtMobile.Text,
                        Course = Course1,
                    };
                   
                    contact.onValidationError += Contact_onValidationError;
                    if (contact.Save() > 0) MessageBox.Show("Student Inserted Successfully");
                          
                }
                catch (FormatException)
                {

                    showError("Invalid Registeration Number Format ");
                }
            }
            else
            {
                if(radioButton1.Checked == true)
                {
                    Contact.Gender = "M";
                }
                else
                {
                    Contact.Gender = "F";
                }
                Contact.Reg_id = Int32.Parse(txtRegID.Text);
                Contact.S_name = txtSName.Text;
                Contact.Dob = dateTime.Text;
               
                Contact.Mobile = txtMobile.Text;
                Contact.Course = Course1;
                if (Contact.Save() > 0) MessageBox.Show("Contact Updated");
            }
        }

        private void Contact_onValidationError(object sender, TsExeptionArgs e)
        {
            if (e.exception.Message.Equals("S_name is required"))
            {
                showError("Student Name Is Required");
            }else if (e.exception.Message.Equals("Gender is required"))
            {
                showError("Gender Is Required");
            }
            else if (e.exception.Message.Equals("Course is required"))
            {
                showError("Course is Required");
            }
            else
            {
                showError(e.exception.Message);
            }
               
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            currentage = DateTime.Today.Year - dateTime.Value.Year;
            txtAge.Text = currentage.ToString();
            if(currentage < 18)
            {
                showError("Cannot Enroll - Below 18 Years");
                return;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (isCollapsed)
            {
                button1.Image = Resources.coll;
                panelDropDown.Height += 10;
                if(panelDropDown.Size== panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button1.Image = Resources.expand;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course1 = "HND-COM";
            button1.Image = Resources.expand;
            panelDropDown.Height -= 132;
            isCollapsed = true;
            timer1.Stop();
            button1.Text= "HND-COM";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Course1 = "HND-BM";
            button1.Image = Resources.expand;
            panelDropDown.Height -= 132;
            isCollapsed = true;
            timer1.Stop();
            button1.Text = "HND-BM";

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Course1 = "DIP-IT";
            button1.Image = Resources.expand;
            panelDropDown.Height -= 132;
            isCollapsed = true;
            timer1.Stop();
            button1.Text = "DIP-IT";

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Course1 = "DIP-English";
            button1.Image = Resources.expand;
            panelDropDown.Height -= 132;
            isCollapsed = true;
            timer1.Stop();
            button1.Text  ="DIP-English";

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Course1 = "DIP-BM";
            button1.Image = Resources.expand;
            panelDropDown.Height -= 132;
            isCollapsed = true;
            timer1.Stop();
            button1.Text = "DIP-BM";
        }
    }
}

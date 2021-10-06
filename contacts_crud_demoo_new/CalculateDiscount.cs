using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TooSharp.Models;

namespace contacts_crud_demoo_new
{
    public partial class CalculateDiscount : Form
    {
        public CalculateDiscount()
        {
            InitializeComponent();
        }
        public CalculateDiscount(Contact contact)
        {
           
            InitializeComponent();
            lblTitle.Text = "Calculate Discount";
            PnlError.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CourseFee = 0;
            int Percentage = 0;
            try
            {

                if (txtCourseFee.Text.Equals(""))
                {
                    CourseFee = Int32.Parse(txtCourseFee.Text);
                    showError("Please Input The Current Couse Fee");
                    
                    return;
                }
                else if (txtDiscount.Text.Equals(""))
                {
                    Percentage= Int32.Parse(txtDiscount.Text);
                    showError("Please Input Discount In Percentage");
                    return;
                }
                Percentage = Int32.Parse(txtDiscount.Text);
                CourseFee = Int32.Parse(txtCourseFee.Text);
                int Disount = (Percentage * 100) / CourseFee;
                ShwoDiscount(Disount,(CourseFee-Disount));
            }
            catch (FormatException)
            {
                showError("Please Input Only Numbers");
            }
         
        }
        void ShwoDiscount(int AfterDiscount, int Discount)
        {
            LblEroor.Text = "Student Discount is Rs."+ Discount+" And The Discount ammount is Rs."+ AfterDiscount;
            PnlError.Visible = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            PnlError.Visible = false;
        }
        void showError(string Text)
        {
            LblEroor.Text = Text;
            PnlError.Visible = true;
            timer1.Start();

        }
    }
}

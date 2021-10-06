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
    public partial class FormContactList : Form
    {
        public FormContactList()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormAddEditContact().ShowDialog();
            ReloadData();
        }

        void ReloadData()
        {
            if(txtSearch.Text.Trim().Length > 0)
            {
                PopulateData(Contacts.Records()
                  .Where(Contacts.COLUMNS.reg_id, "LIKE", "%" + txtSearch.Text + "%")
                  .Get());
                
            }
            else
            {
                PopulateData(Contacts.Records().Get());

            }
        }
        void PopulateData(IEnumerable<Contact> contacts)
        {
            table.Rows.Clear();
            foreach (var contact in contacts)
            {
                table.Rows.Add(new object[]
                {
                    contact.Id,
                    contact.Reg_id,
                    contact.S_name,
                    contact.Dob,
                    contact.Gender,
                    contact.Mobile,
                    contact.Course,
                    "Calculate Discount",
                    "EDIT",
                    "DELETE"
                });
                table.Rows[table.RowCount - 1].Tag = contact;
            }

        }

        private void FormContactList_Shown(object sender, EventArgs e)
        {

            ReloadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            ReloadData();
        }

        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                new CalculateDiscount((Contact)table.CurrentRow.Tag).ShowDialog();
                ReloadData();
            }
            if(e.ColumnIndex == 8)
            {
                new FormAddEditContact((Contact)table.CurrentRow.Tag).ShowDialog();
                ReloadData();
            }
            if(e.ColumnIndex == 9)
            {
                Contact contact = (Contact)table.CurrentRow.Tag;
                if (MessageBox.Show("Delete " + contact.S_name + "?", "CONFIRM", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    contact.Delete();
                    ReloadData();
                }
            }
        }
    }
}

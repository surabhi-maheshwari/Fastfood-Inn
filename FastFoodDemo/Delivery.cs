using FastFoodDemo.classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Delivery : Form
    {

        public Delivery()
        {
            InitializeComponent();
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToResizeColumns = false;
        }
        FastFoodClass f = new FastFoodClass();


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Delivery_Load(object sender, EventArgs e)
        {
        }
        public void Clear()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            //txtID.Text = "";

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            f.Name = txtName.Text;
            f.PhoneNo = txtPhone.Text;
            f.Address = txtAddress.Text;
           // myCollections.dict.
            //Inseting data into database using the method we created 
            bool success = f.Insert(f);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("Delivery information saved");
                //call the method for clearing the fields
                Clear();
            }
            else
            {
                //Failed to add contact
                MessageBox.Show("Failed to insert record. Try Again!");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

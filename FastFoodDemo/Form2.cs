using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFoodDemo.classes;
using System.Diagnostics;

namespace FastFoodDemo
{
    public partial class Form2 : Form
    {
        public double payment = 0;
        public Form2()
        {
            InitializeComponent();
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ClearSelection();
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
            var index = 0;
            foreach (var item in myCollections.dict)
            {
                this.dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.Key;
                dataGridView1.Rows[index].Cells[1].Value = item.Value;
                payment += item.Value;
                index++;
            }
            var currency = "$";
            var total = payment.ToString();
            label2.Text = String.Concat(currency, total);

        }
        FastFoodClass f = new FastFoodClass();
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
            //Inseting data into database using the method we created 
            bool success = f.Insert(f);
            if (success == true)
            {
                //Successfully inserted
               // MessageBox.Show("Delivery information saved");
                //call the method for clearing the fields
                
                Clear();
                System.IO.File.WriteAllText("C:\\Users\\Surabhi Maheshwari\\source\\repos\\FastFoodDemo\\Payment Gateway\\Payment.txt", (payment*100).ToString());
                Process.Start("http://localhost:65212/");
                myCollections.dict.Clear();
                this.Close();
            }
            else
            {
                //Failed to add contact
                MessageBox.Show("Failed to insert record. Try Again!");
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dt = f.Select(); //selects data from database

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

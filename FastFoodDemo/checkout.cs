using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class checkout : UserControl
    {
        public checkout()
        {
            InitializeComponent();
            dataGridView2.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.ClearSelection();
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 15);
            var index = 0;
            foreach (var item in myCollections.dict)
            {
                this.dataGridView2.Rows.Add();
                dataGridView2.Rows[index].Cells[0].Value = item.Key;
                dataGridView2.Rows[index].Cells[1].Value = item.Value;

                index++;
            };
        }

        private void checkout_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}

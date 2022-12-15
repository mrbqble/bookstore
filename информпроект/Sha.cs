using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace информпроект
{
    public partial class Sha : Form
    {
        public Sha()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;

            if (main != null)
            {

                DataRow nRow = main.database8DataSet.Tables[0].NewRow();

                int rc = main.dataGridView2.RowCount + 1;

                nRow[0] = rc;

                nRow[1] = linkLabel1.Text;

                nRow[2] = "А.Кристи";

                nRow[3] = textBox9.Text;

                nRow[4] = Convert.ToInt32(textBox9.Text) * 549;

                main.database8DataSet.Tables[0].Rows.Add(nRow);

                main.таблица1TableAdapter1.Update(main.database8DataSet.Таблица1);

                main.database8DataSet.Tables[0].AcceptChanges();

                main.dataGridView1.Refresh();

                textBox9.Text = "";



            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

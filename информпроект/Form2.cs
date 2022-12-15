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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Логин или пароль не были введены");
            }
            
            Form1 main = this.Owner as Form1;

            if (main != null)
            {

                DataRow nRow = main.регистрацияDataSet1.Tables[0].NewRow();

                int rc = main.dataGridView1.RowCount + 1;

                nRow[0] = rc;

                nRow[1] = textBox1.Text;

                nRow[2] = textBox2.Text;

                main.регистрацияDataSet1.Tables[0].Rows.Add(nRow);

                main.таблица1TableAdapter.Update(main.регистрацияDataSet1.Таблица1);

                main.регистрацияDataSet1.Tables[0].AcceptChanges();

                main.dataGridView1.Refresh();

                textBox1.Text = "";

                textBox2.Text = "";




            }
            Close();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
    }
}

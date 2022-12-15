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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Логин или пароль не были введены");
            }
            else 
            {
            Form1 main = this.Owner as Form1;

            if (main != null)
            {

                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {

                    main.dataGridView1.Rows[i].Selected = false;

                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)

                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)

                            if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text) && main.dataGridView1.Rows[i].Cells[j + 1].Value.ToString().Contains(textBox2.Text))
                            {

                                Form4 af = new Form4();

                                af.Owner = this;

                                af.Show();
                                break;

                            }

                }
            }
            }
        }
    }
}

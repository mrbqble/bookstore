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
    public partial class Poisk : Form
    {
        public Poisk()
        {
            InitializeComponent();
        }

        private void Poisk_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int z=0;
           Form4 main = this.Owner as Form4;

            if (main != null)
            {

                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {

                    main.dataGridView1.Rows[i].Selected = false;

                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                    {
                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {

                                main.dataGridView1.Rows[i].Selected = true;
                                z = z + 1;
                                break;
                            }
                            
                            
                        }
                    }
                }
            } if (z == 0)
            {
                MessageBox.Show("Данная книга,автор или жанр не присутствует");
            }
        }
    }
}

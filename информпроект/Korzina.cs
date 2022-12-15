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
    public partial class Korzina : Form
    {
        public Korzina()
        {
            InitializeComponent();
        }

        private void Korzina_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database8DataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.database8DataSet.Таблица1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
            this.таблица1TableAdapter.Update(this.database8DataSet.Таблица1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                a = a + Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            MessageBox.Show("Итоговый счет:" + a.ToString());
        }
    }
}

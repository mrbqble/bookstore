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
    public partial class Ise : Form
    {
        public Ise()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;

            if (main != null)
            {

                DataRow nRow = main.database8DataSet.Tables[0].NewRow();

                int rc = main.dataGridView2.RowCount + 1;

                nRow[0] = rc;

                nRow[1] = linkLabel2.Text;

                nRow[2] = "Д.Роулинг";

                nRow[3] = textBox10.Text;

                nRow[4] = Convert.ToInt32(textBox10.Text) * 425;

                main.database8DataSet.Tables[0].Rows.Add(nRow);

                main.таблица1TableAdapter1.Update(main.database8DataSet.Таблица1);

                main.database8DataSet.Tables[0].AcceptChanges();

                main.dataGridView1.Refresh();

                textBox10.Text = "";



            }
        }
    }
}

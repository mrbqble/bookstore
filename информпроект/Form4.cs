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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poisk af = new Poisk();

            af.Owner = this;

            af.Show();
        }

        private void магазиныToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void романToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void детективToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void развитиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void фантастикаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void научнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void корзинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Korzina af = new Korzina();

            af.Owner = this;

            af.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database8DataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter1.Fill(this.database8DataSet.Таблица1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database9DataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.database9DataSet.Таблица1);

        }

        private void мастерИМаргаритаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mam af = new Mam();

            af.Owner = this;

            af.Show();
        }

        private void преступлениеИНаказаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cap af = new Cap();

            af.Owner = this;

            af.Show();
        }

        private void войнаИМирToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wap af = new Wap();

            af.Owner = this;

            af.Show();
        }

        private void приключениеШерлокаХолмсаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sha af = new Sha();

            af.Owner = this;

            af.Show();
        }

        private void убийствоВToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mie af = new Mie();

            af.Owner = this;

            af.Show();
        }

        private void кодДаВинчиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kdv af = new Kdv();

            af.Owner = this;

            af.Show();
        }

        private void наСлужбеЗлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ise af = new Ise();

            af.Owner = this;

            af.Show();
        }

        private void войнаМировToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ww af = new Ww();

            af.Owner = this;

            af.Show();
        }

        private void какЯСталИдиотомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hibi af = new Hibi();

            af.Owner = this;

            af.Show();
        }

        private void похоронитеМеняЗаПлинтусомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pmz af = new Pmz();

            af.Owner = this;

            af.Show();
        }

        private void мыбогиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Wg af = new Wg();

            af.Owner = this;

            af.Show();
        }

        private void цветыДляЭлджорнонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ffa af = new Ffa();

            af.Owner = this;

            af.Show();
        }

        private void зеленаяМиляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gm af = new Gm();

            af.Owner = this;

            af.Show();
        }

        private void виноИзОдуванчиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Woo af = new Woo();

            af.Owner = this;

            af.Show();
        }

        private void противостояниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prot af = new Prot();

            af.Owner = this;

            af.Show();
        }

        private void охотникиЗаМикробамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gh af = new Gh();

            af.Owner = this;

            af.Show();
        }

        private void живойКакЖизньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All af = new All();

            af.Owner = this;

            af.Show();
        }

        private void краткаяИсторияВремениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tss af = new Tss();

            af.Owner = this;

            af.Show();
        }

        private void sapiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hss af = new Hss();

            af.Owner = this;

            af.Show();
        }

        private void ночьВЛиссабонеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NaL af = new NaL();

            af.Owner = this;

            af.Show();
        }
    }
}

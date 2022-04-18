using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен_ПМ._01
{
    public partial class Заказ : Form
    {
        public Заказ()
        {
            InitializeComponent();
        }

        //Возвращает на главное окно
        private void button1_Click(object sender, EventArgs e)
        {
            ГлавноеОкно главное = new ГлавноеОкно();
            главное.Show();
            this.Close();
        }
    }
}

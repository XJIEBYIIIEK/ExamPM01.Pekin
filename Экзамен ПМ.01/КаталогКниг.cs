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
    public partial class КаталогКниг : Form
    {
        public КаталогКниг()
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

        //Загружает таблицу Книги в DataGridView
        private void КаталогКниг_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Экзамен_ПМ_01_ПекинDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this._Экзамен_ПМ_01_ПекинDataSet.Книги);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен_ПМ._01
{
    public partial class ГлавноеОкно : Form
    {
        public ГлавноеОкно()
        {
            InitializeComponent();
        }

        //Переходит на окно с корзиной
        private void button1_Click(object sender, EventArgs e)
        {
            Корзина корзина = new Корзина();
            корзина.Show();
            this.Hide();
        }

        //Переходит на окно с заказом
        private void button2_Click(object sender, EventArgs e)
        {
            Заказ заказ = new Заказ();
            заказ.Show();
            this.Hide();
        }
        
        //Переходит на окно с каталогом книг
        private void button3_Click(object sender, EventArgs e)
        {
            КаталогКниг каталог = new КаталогКниг();
            каталог.Show();
            this.Hide();
        }

        //Загружает таблицу Книги в DataGridView
        private void ГлавноеОкно_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Экзамен_ПМ_01_ПекинDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this._Экзамен_ПМ_01_ПекинDataSet.Книги);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

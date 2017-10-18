using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyController
{
    public partial class Form1 : Form
    {
        List<Lists.MoneyStorage> list = new List<Lists.MoneyStorage>();
        SQLControl controle = new SQLControl();
        public double total;
        public Form1()
        {
            InitializeComponent();
        }
        private void AddNew_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog(this);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            controle.NextMonth();
        }
        private void Ler_Click(object sender, EventArgs e)
        {
            list = controle.LerTabela();
            var lista = new BindingList<Lists.MoneyStorage>(list);
            data.DataSource = list;
            int i = 0;
            total = 0;
            while (i < list.Count)
            {
                total += Convert.ToDouble(list[i].Quantia);
                i++;
            }
            textBox1.Text = total.ToString();
            
        }
        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void erase_Click(object sender, EventArgs e)
        {
            //controle.Truncate();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void AddInfo_Click(object sender, EventArgs e)
        {
            Infos info = new Infos(this, list);
            info.ShowDialog(this);
        }

        private void ConnInfo_Click(object sender, EventArgs e)
        {
            InfoConexao conex = new InfoConexao();
            conex.ShowDialog(this);
        }
    }
}

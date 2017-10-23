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
        List<Lists.MoneyStorage> listaGrande;
        SQLControl controle = new SQLControl();
        public double total;
        bool jaLi = false, anteriores = false;
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
            //controle.NextMonth();
            LerTable();
        }
        private void Ler_Click(object sender, EventArgs e)
        {
            LerTable();
        }
        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void erase_Click(object sender, EventArgs e)
        {
            //controle.Truncate();
            if (jaLi && !anteriores)
            {
                int i = data.CurrentRow.Index;
                if (MessageBox.Show("Você tem certeza que deseja apagar a linha " + (i + 1).ToString() + "?", "Duvidas", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    controle.DeleteRow(listaGrande[i].Quantia, listaGrande[i].Local, listaGrande[i].DinCard, listaGrande[i].Data,
                                       listaGrande[i].Hora, listaGrande[i].PagRec);
                    MessageBox.Show("Linha Apagada!", "Aviso");
                    LerTable();
                }
            }
            else
                MessageBox.Show("Erro. Clique em Ler", "Erro");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void AddInfo_Click(object sender, EventArgs e)
        {
            if (jaLi)
            {
                Infos info = new Infos(this, listaGrande);
                info.ShowDialog(this);
            }
            else
                MessageBox.Show("Erro. Clique em Ler", "Erro");
        }
        private void ConnInfo_Click(object sender, EventArgs e)
        {
            InfoConexao conex = new InfoConexao();
            conex.ShowDialog(this);
        }
        private void Legacy_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Você deseja ler o Legacy?", "Duvidas", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
               // Leitura("MoneyLegacy");

          //  else if(MessageBox.Show("Você deseja ler o BackUp?", "Duvidas", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                LeituraBK("MoneyStorageBackUp");
            
        }
        private void BackUp_Click(object sender, EventArgs e)
        {
            controle.MakeBackUp();
        }
        private void ApagarBK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja apagar o back up?", "Duvidas", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                controle.ApagarBackUp();
        }
        private void Leitura(string qual)
        {
            var list = controle.LerTabela(qual);

            var lista = new BindingList<Lists.MoneyStorage>(list);
            data.DataSource = list;
            int i = 0;
            total = 0;
            while (i < list.Count)
            {
                //total += Convert.ToDouble(list[i].Quantia);
                if (list[i].PagRec.Replace(" ", "") == "Recebimento")
                    total += Convert.ToDouble(list[i].Quantia);
                else
                    total -= Convert.ToDouble(list[i].Quantia);

                i++;
            }
            textBox1.Text = total.ToString();
            jaLi = false;
            anteriores = true;
        }
        private void LerTable()
        {
            listaGrande = controle.LerTabela("MoneyStorage");
            for(int j = 0; j < listaGrande.Count; j++)
            {
                listaGrande[j].RemoveSpace();
            }
            var lista = new BindingList<Lists.MoneyStorage>(listaGrande);
            data.DataSource = listaGrande;
            int i = 0;
            total = 0;
            while (i < listaGrande.Count)
            {
                //total += Convert.ToDouble(list[i].Quantia);
                if (listaGrande[i].PagRec.Replace(" ", "") == "Recebimento")
                    total += Convert.ToDouble(listaGrande[i].Quantia);
                else
                    total -= Convert.ToDouble(listaGrande[i].Quantia);

                i++;
            }
            textBox1.Text = total.ToString();
            jaLi = true;
        }
          private void LeituraBK(string qual)
        {
            var list = controle.LerTabelaBackUp("MoneyStorageBackUp");
            var lista = new BindingList<Lists.MoneyStorageBackUp>(list);
            data.DataSource = list;
            int i = 0;
            total = 0;
            while (i < list.Count)
            {
                //total += Convert.ToDouble(list[i].Quantia);
                if (list[i].Pag_Rec.Replace(" ", "") == "Recebimento")
                    total += Convert.ToDouble(list[i].Quantia);
                else
                    total -= Convert.ToDouble(list[i].Quantia);

                i++;
            }
            textBox1.Text = total.ToString();
            jaLi = false;
            anteriores = true;
        }

          private void Outros_Click(object sender, EventArgs e)
          {
              Informacoes.PagamentosFixos pagFix = new Informacoes.PagamentosFixos();
              pagFix.ShowDialog(this);

          }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyController.Informacoes
{
    public partial class PagamentosFixos : Form
    {
        SQLControl controle = new SQLControl();
        List<Lists.LocalTable> LocalList;
        public PagamentosFixos()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void AttLocal()
        {
            int i = 0;
            local.Items.Clear();
            LocalList = controle.ReadLocalTable();
            while (i < LocalList.Count)
            {
                local.Items.Add(LocalList[i].Nome);
                i++;
            }
        }

        private void AddLocal_Click(object sender, EventArgs e)
        {
            int i = 0;
            Inserts.AddLocal adicione = new Inserts.AddLocal();
            adicione.ShowDialog(this);
            LocalList.Clear();
            LocalList = null;
            AttLocal();
        }

        private void PagamentosFixos_Load(object sender, EventArgs e)
        {
            AttLocal();
            DiaPag.Text = DateTime.Now.ToShortDateString().Substring(0,2);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Quantia.Text != "" && DiaPag.Text != "" && DiaPag.TextLength == 2)
            {
                controle.AttInsertPayTable(Quantia.Text, local.SelectedItem.ToString(), DiaPag.Text);
                MessageBox.Show("Feito", "Sucesso?");
            }

            else
                MessageBox.Show("Olhe seus dados");
        }
    }
}

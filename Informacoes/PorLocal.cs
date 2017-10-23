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
    public partial class PorLocal : Form
    {
        List<Lists.LocalTable> lista;
        SQLControl controle = new SQLControl();
        public PorLocal()
        {
            InitializeComponent();
            controle.AttQuantiaLocais();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void PorLocal_Load(object sender, EventArgs e)
        {
            lista = controle.ReadLocalTable();
            txt.SelectionColor = Color.Black;
            txt.AppendText(lista[0].Nome.Replace(" ", "") + ": R$");
            if (lista[0].Quantia.Contains('-'))
                txt.SelectionColor = Color.Red;
            else
                txt.SelectionColor = Color.Green;
            txt.AppendText(lista[0].Quantia.Replace(" ", "").Replace("-", ""));
            for (int i = 1; i < lista.Count; i++)
            {
                txt.SelectionColor = Color.Black;
                txt.AppendText("\n" + lista[i].Nome.Replace(" ", "") + ": R$");
                if (lista[i].Quantia.Contains('-'))
                    txt.SelectionColor = Color.Red;
                else
                    txt.SelectionColor = Color.Green;

                txt.AppendText(lista[i].Quantia.Replace(" ", "").Replace("-", ""));
            }
        }
    }
}

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
    public partial class PagFixo : Form
    {
        List<Lists.PagFixoTable> listaGrande;
        SQLControl controle = new SQLControl();
        public PagFixo()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void PagFixo_Load(object sender, EventArgs e)
        {
            listaGrande = controle.ReadPagFixo();
            for (int j = 0; j < listaGrande.Count; j++)
            {
                listaGrande[j].RemoveSpace();
            }
            var lista = new BindingList<Lists.PagFixoTable>(listaGrande);
            data.DataSource = listaGrande;
        }
    }
}

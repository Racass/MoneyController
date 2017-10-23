using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyController.Inserts
{
    public partial class AddLocal : Form
    {
        public AddLocal()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SQLControl controle = new SQLControl();
            controle.InsertLocalTable(Nome.Text, Endereco.Text);
            MessageBox.Show("Inserido com sucesso.", "Sucesso!");
        }
    }
}

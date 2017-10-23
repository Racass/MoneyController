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
    public partial class Pergunta : Form
    {
        Form1 retorno;
        public Pergunta(string label, Form1 formado)
        {
            InitializeComponent();
            Texto.Text = label;
            retorno = formado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }
    }
}

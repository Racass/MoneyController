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
    public partial class AddForm : Form
    {
        bool JaSalvei = false;
        SQLControl controle = new SQLControl();
        string qual = "";
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            DataBox.Text = DateTime.Now.ToShortDateString();
            HourBox.Text = DateTime.Now.ToShortTimeString();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if(JaSalvei)
                this.DestroyHandle();

            else if(MessageBox.Show("Você tem certeza? Os dados não foram salvos ainda.", "Dúvidas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    this.DestroyHandle();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (qual != "")
            {
                if (controle.InsertInto(QuantBox.Text, LocalBox.Text, qual, DataBox.Text, HourBox.Text))
                {
                    QuantBox.Text = "";
                    LocalBox.Text = "";
                    MessageBox.Show("Dados Adicionados com sucesso", "Parabéns!");
                    JaSalvei = true;
                }
                else
                {
                    JaSalvei = false;
                    MessageBox.Show("Erro ao adicionar", "Erro!");
                }
            }
            else
                MessageBox.Show("Erro ao adicionar. Selecione Deb/Cred", "Erro!");
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            JaSalvei = false;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            JaSalvei = false;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            JaSalvei = false;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            JaSalvei = false;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            JaSalvei = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
                qual = "Deb";
            else if (listBox1.SelectedIndex == 1)
                qual = "Cred";
            else
                qual = "Poup";
        }


    }
}

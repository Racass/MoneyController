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
        List<Lists.LocalTable> LocalList;
        bool JaSalvei = false;
        string Plus = "";
        SQLControl controle = new SQLControl();
        string qual = "";
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddNew_Load(object sender, EventArgs e)
        {
            int i = 0;
            DataBox.Text = DateTime.Now.ToShortDateString();
            HourBox.Text = DateTime.Now.ToShortTimeString();
            LocalList = controle.ReadLocalTable();
            while(i < LocalList.Count)
            {
                locais.Items.Add(LocalList[i].Nome);
                i++;
            }
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
            if (PlusMinus.Checked == true)
                Plus = "Plus";
            else
                Plus = "Minus";
            if (qual != "" && QuantBox.Text != "" && locais.SelectedItem.ToString() != null && DataBox.Text != "" && HourBox.Text != "")
            {
                if (controle.InsertInto(QuantBox.Text, locais.SelectedItem.ToString(), qual, DataBox.Text, HourBox.Text, Plus))
                {
                    QuantBox.Text = "";
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
        private void PlusMinus_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void NewLocal_Click(object sender, EventArgs e)
        {
            int i = 0;
            Inserts.AddLocal adicione = new Inserts.AddLocal();
            adicione.ShowDialog(this);
            LocalList.Clear();
            LocalList = null;
            locais.Items.Clear();
            LocalList = controle.ReadLocalTable();
            while (i < LocalList.Count)
            {
                locais.Items.Add(LocalList[i].Nome);
                i++;
            }
        }


    }
}

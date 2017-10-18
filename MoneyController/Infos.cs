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
    public partial class Infos : Form
    {
        Form1 parent;
        List<Lists.MoneyStorage> listagem = new List<Lists.MoneyStorage>();
        double byDay = 0;
        public Infos(Form1 form, List<Lists.MoneyStorage> lista) 
        {
            InitializeComponent();
            parent = form;
            listagem = lista;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int divisor = GetDifDias(DateTime.Now, Convert.ToDateTime(@"30/09/" + DateTime.Now.Year.ToString()));
            if(divisor != 0)
                byDay = parent.total / divisor;
            dayByDay.Text = byDay.ToString();
            CalcDebit();
            CalcRDebit(divisor);
        }
        public int GetDifDias(DateTime initialDate, DateTime finalDate)
        {
            var days = 0;
            var daysCount = 0;
            days = initialDate.Subtract(finalDate).Days;

            if (days < 0)
                days = days * -1;

            for (int i = 1; i <= days; i++)
            {
                initialDate = initialDate.AddDays(1);

                if (initialDate.DayOfWeek != DayOfWeek.Sunday &&
                    initialDate.DayOfWeek != DayOfWeek.Saturday)
                    daysCount++;
            }
            return daysCount;
        }
        private void Debit_TextChanged(object sender, EventArgs e)
        {

        }
        private void CalcRDebit(int divisor)
        {
            double cont = 0, debit = 0;
            int i = 0;
            while (i < listagem.Count)
            {
                if (listagem[i].DinCard.Replace(" ", "") == "Deb")
                    debit += Convert.ToDouble(listagem[i].Quantia);
                i++;
            }
            cont = debit / divisor;
            RDebit.Text = cont.ToString();
        }
        private void CalcDebit()
        {
            int i = 0;
            double debit = 0;
            double credit = 0;
            double poup = 0;
            while( i < listagem.Count)
            {
                if (listagem[i].DinCard.Replace(" ", "") == "Deb")
                {
                    if (listagem[i].PlusMinus.Replace(" ", "") == "Plus")
                        debit += Convert.ToDouble(listagem[i].Quantia);
                    else
                        debit -= Convert.ToDouble(listagem[i].Quantia);
                }
                else if (listagem[i].DinCard.Replace(" ", "") == "Cred")
                {
                    if (listagem[i].PlusMinus.Replace(" ", "") == "Plus")
                        credit += Convert.ToDouble(listagem[i].Quantia);
                    else
                        credit -= Convert.ToDouble(listagem[i].Quantia);
                }

                else
                {
                    if (listagem[i].PlusMinus.Replace(" ", "") == "Plus")
                        poup += Convert.ToDouble(listagem[i].Quantia);
                    else
                        credit -= Convert.ToDouble(listagem[i].Quantia);
                }
                i++;
            }
            card.Text = credit.ToString();
            din.Text = debit.ToString();
            poupanc.Text = poup.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.DestroyHandle();
        }

        private void Infos_Load(object sender, EventArgs e)
        {

        }
    }
}

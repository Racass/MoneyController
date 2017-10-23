using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyController.Lists
{
    class PagFixoTable
    {
        public string Quantia { get; set; }
        public string Local { get; set; }
        public string DiaPagamento { get; set; }

        public void RemoveSpace()
        {
            Quantia = Quantia.Replace(" ", "");
            Local = Local.Replace(" ", "");
            DiaPagamento = DiaPagamento.Replace(" ", "");
        }
    }
}

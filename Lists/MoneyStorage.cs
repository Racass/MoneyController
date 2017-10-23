using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyController.Lists
{
    public class MoneyStorage
    {
        public string Quantia { get; set; }
        public string Local { get; set; }
        public string DinCard { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string PagRec { get; set; }
        public void RemoveSpace()
        {
            Quantia = Quantia.Replace(" ", "");
            Local = Local.Replace(" ", "");
            DinCard = DinCard.Replace(" ", "");
            Data = Data.Replace(" ", "");
            Hora = Hora.Replace(" ", "");
            PagRec = PagRec.Replace(" ", "");
        }
    }
}

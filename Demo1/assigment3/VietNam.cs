using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.assigment3
{
    public class VietNam : Customer
    {
        public string Doituong { get; set; }
        public VietNam(int Id, string Name, string Date, int Quantity, string Doituong) : base(Id, Name, Date, Quantity)
        {
            this.Doituong = Doituong;
        }
        
        public override int Total()
        {
            if (Quantity < 50)
                return Quantity * 10000;
            else if (Quantity < 100)
                return (Quantity - 50) * 1200 + 50 * 1000;
            else if (Quantity < 200)
                return (Quantity - 100) * 1500 + 50 * 1200 + 50 * 1000;
            else
                return (Quantity - 200) * 2000 + 100 * 1500 + 50 * 1200 + 50 * 1000;
            
        }
    }
}

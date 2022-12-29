using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.assigment3
{
    public class NgoaiQuoc : Customer
    {
        public string Quoctich;
        public NgoaiQuoc(int Id, string Name, string Date, int Quantity, string Quoctich) : base(Id, Name, Date, Quantity)
        {
            this.Quoctich = Quoctich;
        }

        public override int Total()
        {
            return base.Total();
        }
    }
}

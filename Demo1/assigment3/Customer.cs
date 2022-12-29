using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.assigment3
{
    public abstract class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }

        public Customer()
        {

        }

        protected Customer(int id, string name, string date, int quantity)
        {
            Id = id;
            Name = name;
            Date = date;
            Quantity = quantity;
        }

        public virtual int Total()
        {
            return Quantity * 2000;
        }
    }
}

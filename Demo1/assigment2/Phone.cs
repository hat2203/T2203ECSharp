using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.assigment2
{
    public abstract class Phone
    {

        public abstract void InsertPhone(string name, string phone);

        public abstract void RemovePhone(string name);

        public abstract void UpdatePhone(string name, string oldPhone, string newPhone);

        public abstract PhoneNumber SearchPhone(string name);

        public abstract void Soft();
    }
}

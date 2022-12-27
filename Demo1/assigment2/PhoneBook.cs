using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.assigment2
{
    public class PhoneBook : Phone
    {
        
        public PhoneBook()
        {
            pList = new List<PhoneNumber>();
        }


        public List<PhoneNumber> pList { get; }


        public override void InsertPhone(string name, string phoneNumber)
        {
           foreach(PhoneNumber pn in pList)
            {
                if (pn.Name.Equals(name))
                {
                    if (pn.Phone.Contains(phoneNumber))
                    {
                        return;
                    }
                    pn.Phone.Add(phoneNumber);
                    return;
                }
            }
            PhoneNumber np = new PhoneNumber(name, phoneNumber);
            pList.Add(np);
        }

        public override void RemovePhone(string name)
        {
            foreach(PhoneNumber pn in pList)
            {
                if (pn.Name.Equals(name))
                {
                    pList.Remove(pn);
                    return;
                }
            }
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach (PhoneNumber pn in pList)
            {
                if (pn.Name.Equals(name))
                {
                    return pn;
                }
            }
            return null;
        }

        public override void Soft()
        {
            pList.Sort((p1, p2) =>
            {
                return p1.Name.CompareTo(p2.Name);
            });
        }

        public override void UpdatePhone(string name,string oldPhone, string newPhone)
        {
            foreach(PhoneNumber pn in pList)
            {
                if (pn.Name.Equals(name) && pn.Phone.Contains(oldPhone)){
                    pn.Phone.Remove(oldPhone);
                    pn.Phone.Add(newPhone);
                    return;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.session1
{
    public class Student : Human // dau : la ke thua tuong duong extent trong java
    {

        private string[] telephone = new string[3];

        public Student()
        { 
        }

        public Student(string s, int a) : base(s)
        {
            this.Age = a;
        }

        public string this[int index] // <=> indexer
        {
            get => telephone[index];
            set => telephone[index] = value;
        }
        public void Study()
        {
            base.Run();
        }

        public override void Eat() // sang lop ke thua can phai co override de bao hieu la co ghi de
        {
           
        }
    }
}

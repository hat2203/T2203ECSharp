using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.session4
{
    public delegate void StringToVoid(string s);
    public class DemoDelegate
    {
        public DemoDelegate()
        {

        }

        public void ShowInfor(string s)
        {
            Console.WriteLine(s);
        }

        public static void SayHello(string str)
        {
            Console.WriteLine("Say: " + str);
        }
    }
}

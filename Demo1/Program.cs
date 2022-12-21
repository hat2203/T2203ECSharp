using Demo1.assigment1;
using Demo1.session1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            h.Run();
            Human dvt = new Human();
            dvt.Run();
            h.Age = 19;
            h.Email = "nguyenvanA@gmail.com";

            Student s = new Student();
            s[0] = "0123456789";
            List<string> ls = new List<string>();
            ls.Add("Hello");
            ls.Add("world");
            ls.Add("good morning");

            for(int i=0; i<ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }

            foreach(string l in ls)
            {
                Console.WriteLine(l);
            }

            PhanSo ps = new PhanSo();
            ps.NhapPhanSo();
            ps.RutGonPhanSo();
            ps.InPhanSo();
            ps.NghichDaoPhanSo();
            ps.InPhanSo();

            PhanSo ps2 = new PhanSo();
            ps2.NhapPhanSo();
            ps2.InPhanSo();

            PhanSo f = ps.Add(ps2);
            f.InPhanSo();
            
        }
    }
}

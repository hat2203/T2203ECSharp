using Demo1.assigment1;
using Demo1.assigment2;
using Demo1.assigment3;
using Demo1.assigment4;
using Demo1.session1;
using Demo1.session4;
using Demo1.session5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fetch();
        }
        static async void Fetch()
        {
            CallApiWeather ca = new CallApiWeather();
            ApiWeather aw = await ca.FetchData();
            Console.WriteLine(aw.ToString());

            //CallApi ca = new CallApi();
            //Product s = await ca.FetchData();
            //Console.WriteLine(s.ToString());
        }
        static void Main6(string[] args)
        {
            //Thread t1 = new Thread(ThreadRun);
            //Thread t2 = new Thread(ThreadRunParam);
            //t2.IsBackground = true;
            //t1.Start();
            //t2.Start("Done");

            Number num = new Number()
            {
                X = 0,
                Y = 0
            };
            Thread n1 = new Thread(ThreadLock);
            Thread n2 = new Thread(ThreadLock);
            n1.Start(num);
            n2.Start(num);
            
        }

        static void ThreadLock(object o)
        {

            Number n = (Number)o;
            for(int i=0; i<20; i++)
            {
                lock (n)
                {
                    n.ChangeXY();
                    n.PrintXY();
                }
                try
                {

                    Thread.Sleep(1000);
                }catch(Exception e) { }
            }
        }

        static void ThreadRun()
        {
            for(int i = 0; i <20; i++)
            {
                Console.WriteLine("i= " + i);
                try 
                {
                    Thread.Sleep(1000);
                }
                catch(Exception e) { }
            }
        }

        static void ThreadRunParam(object msg)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("i= " + i + " Msg: "+msg);
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e) { }
            }
        }
        static void Main5(string[] args)
        {
            VietNam a = new VietNam(1, "Nguyen Van A", "30/12/2020", 20, "Ca nhan");
            Console.WriteLine(a.Total());
            NgoaiQuoc n = new NgoaiQuoc(2, "Jonh", "30/12/2020", 15, "US");
            Console.WriteLine(n.Total());
        }

        static void Main4(string[] args)
        {
            StringToVoid stv = new StringToVoid(ShowMessage);
            StringToVoid stv2 = new StringToVoid(DemoDelegate.SayHello);
            StringToVoid stv3 = new StringToVoid(new DemoDelegate().ShowInfor);

            stv += DemoDelegate.SayHello;
            stv("xin chao cac ban");

            DemoEvent de = new DemoEvent();
            de.Invoke();

        }
        static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main3(string[] args)
        {
            PhoneBook pb = new PhoneBook();
            pb.InsertPhone("Nguyen Van Anh", "0236553996");
            pb.InsertPhone("Nguyen Van Tu", "0338984053");
            pb.InsertPhone("Nguyen Van Anh", "0179227185");
            pb.InsertPhone("Nguyen Van Anh", "0236553996");
            pb.InsertPhone("Nguyen Van Lam", "0989225618");

            foreach(PhoneNumber pn in pb.pList)
            {
                Console.WriteLine(pb.ToString());
            }
        }
        static void Main1(string[] args)
        {
            try
            {
                int x = 10;
                int y = 0;
                throw new Exception("Y bang 0 mat roi, khong the chia cho 0");
                float z = x/ y;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }
        }
        static void Main2(string[] args)
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

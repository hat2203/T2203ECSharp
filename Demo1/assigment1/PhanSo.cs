using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.assigment1
{
    public class PhanSo
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }

        public PhanSo()
        {

        }
        public void NhapPhanSo()
        {
            Console.WriteLine("Vui long nhap phan so");

        }

        public void InPhanSo()
        {
            Console.WriteLine(TuSo + "/" + MauSo);
        }

        public void RutGonPhanSo()
        {
            int Ucln = 1;
            for(int i= Math.Min(Math.Abs(TuSo),Math.Abs(MauSo)); i>1; i--)
            {
                if(TuSo % i == 0 && MauSo % i == 0)
                {
                    Ucln = i;
                }
            }
            TuSo = TuSo / Ucln;
            MauSo = MauSo / Ucln;
        }

        public void NghichDaoPhanSo()
        {
            int tmp = TuSo;
            TuSo = MauSo;
            MauSo = tmp;
        }

        public void Add(PhanSo f)
        {

        }

        public void Sub()
        {

        }

        public void Mul()
        {

        }

        public void Div()
        {

        }

    }
}

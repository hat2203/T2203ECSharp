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
            Console.Write("Tu so: ");
            this.TuSo = int.Parse(Console.ReadLine());
            Console.Write("Mau so: ");
            this.MauSo = int.Parse(Console.ReadLine());

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

        public PhanSo Add(PhanSo f)
        {
            PhanSo tong = new PhanSo();
            tong.TuSo = (this.TuSo * f.MauSo) + (this.MauSo * f.TuSo);
            tong.MauSo = this.MauSo * f.MauSo;
            tong.RutGonPhanSo();
            return tong;
        }

        public PhanSo Sub(PhanSo f)
        {
            PhanSo hieu = new PhanSo();
            hieu.TuSo = (this.TuSo * f.MauSo) - (this.MauSo * f.TuSo);
            hieu.MauSo = this.MauSo * f.MauSo;
            hieu.RutGonPhanSo();
            return hieu;
        }

        public PhanSo Mul(PhanSo f)
        {
            PhanSo tich = new PhanSo();
            tich.TuSo = this.TuSo * f.TuSo;
            tich.MauSo = this.MauSo * f.MauSo;
            tich.RutGonPhanSo();
            return tich;
        }

        public PhanSo Div(PhanSo f)
        {
            PhanSo thuong = new PhanSo();
            thuong.TuSo = this.TuSo * f.MauSo;
            thuong.MauSo = this.MauSo * f.TuSo;
            thuong.RutGonPhanSo();
            return thuong;
        }

    }
}

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
            int z = TuSo;
            TuSo = MauSo;
            MauSo = z;
        }

        public PhanSo Add(PhanSo ps)
        {
            PhanSo tong = new PhanSo();
            tong.TuSo = (this.TuSo * ps.MauSo) + (this.MauSo * ps.TuSo);
            tong.MauSo = this.MauSo * ps.MauSo;
            tong.RutGonPhanSo();
            return tong;
        }

        public PhanSo Sub(PhanSo ps)
        {
            PhanSo hieu = new PhanSo();
            hieu.TuSo = (this.TuSo * ps.MauSo) - (this.MauSo * ps.TuSo);
            hieu.MauSo = this.MauSo * ps.MauSo;
            hieu.RutGonPhanSo();
            return hieu;
        }

        public PhanSo Mul(PhanSo ps)
        {
            PhanSo tich = new PhanSo();
            tich.TuSo = this.TuSo * ps.TuSo;
            tich.MauSo = this.MauSo * ps.MauSo;
            tich.RutGonPhanSo();
            return tich;
        }

        public PhanSo Div(PhanSo ps)
        {
            PhanSo thuong = new PhanSo();
            thuong.TuSo = this.TuSo * ps.MauSo;
            thuong.MauSo = this.MauSo * ps.TuSo;
            thuong.RutGonPhanSo();
            return thuong;
        }

    }
}

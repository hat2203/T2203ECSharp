using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.assigment5
{
    public class House : IHouse
    {
        private string soNha;
        private string diaChi;
        private string loaiNha;

        public House()
        {

        }

        public string SoNha
        {
            get => soNha;
            set => soNha = value;
        }

        public string DiaChi
        {
            get => diaChi;
            set => diaChi = value;
        }

        public string LoaiNha
        {
            get => loaiNha;
            set => loaiNha = value;
        }


        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Input()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.practice_exam
{
    internal class Process
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.Write("Radius:");
            this.Radius = double.Parse(Console.ReadLine());
            Console.Write("Height:");
            this.Height = double.Parse(Console.ReadLine());
        }

        public double Basarea()
        {
             
            return Basarea();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Family
    {
        public Human Husband { get; set; }
        public Human Wife { get; set; }
        public void Print()
        {

            Husband.Print(); Console.Write("+ "); Wife.Print();
            Console.WriteLine(" ");
            Console.Write("         ");
        }

    }
}

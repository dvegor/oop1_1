using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Gender
    {
        Male,
        Female
    }
    public class Human
    {
        public Family Parents { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }

        public override string ToString()
        {
            return Name;
        }
        public void Print()
        {

            Console.Write($"{Name} ");
            Parents?.Print();
        }


    }
}

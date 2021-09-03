using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Greater
    {
        public void max()
        {
            Console.WriteLine("without parameters");
        }
        public void max(int a, int b)
        {

        }

        public float max(float a, float b)
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Greater g = new Greater();
            g.max(23, 34);
            g.max(10.3F, 20.3F);
            Console.ReadKey();

        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory;

namespace TestFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            ICar myCar = CreateFactory.GetObject("Audi");
            myCar.Drive();

            Console.ReadKey();
        }
    }
}

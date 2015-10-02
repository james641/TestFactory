using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory;
using TestInterface;

namespace TestFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            //ICar myCar = CreateFactory.GetObject("Audi");
            //myCar.Drive();

            CA a = new CA() { Name = "John Doe", Age = 35 };
            CB b = new CB() { First = "Jane", Last = "Doe", PersonsAge = 33 };

            PrintInfo(a);
            PrintInfo(b);


            Console.ReadKey();
        }

        static void PrintInfo(IInfo item)
        {
            Console.WriteLine("Name: {0},Age {1}",item.GetName(),item.GetAge());
        }
    }
}

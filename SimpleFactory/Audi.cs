using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Audi : ICar
    {
        public void Drive()
        {
            Console.WriteLine("开奥迪");
        }
    }
}

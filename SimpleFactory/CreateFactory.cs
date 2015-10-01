using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class CreateFactory
    {
        public static ICar GetObject(string objName)
        {
            switch (objName)
            {
                case "Benz":
                    return new Benz();
                case "Bmw":
                    return new Bmw();
                case "Audi":
                    return new Audi();
                default:
                    throw new NotImplementedException();
            }
        }

    }
}

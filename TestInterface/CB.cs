using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    public class CB:IInfo
    {
        public string First;
        public string Last;
        public double PersonsAge;

        public string GetAge()
        {
            return PersonsAge.ToString();
        }

        public string GetName()
        {
            return this.First + " " + this.Last;
        }
    }
}

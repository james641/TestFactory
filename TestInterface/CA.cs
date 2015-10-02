using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface
{
    public class CA:IInfo
    {
        public string Name;
        public int Age;

        public string GetName()
        {
            return this.Name;
        }

        public string GetAge()
        {

            return this.Age.ToString();
        }
    }
}

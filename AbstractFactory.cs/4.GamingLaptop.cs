using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.cs
{
    public class GamingLaptop : ILaptop
    {
        public string Name()
        {
            return "Gaming Laptop";
        }
    }
}

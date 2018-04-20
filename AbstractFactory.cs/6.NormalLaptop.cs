using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.cs
{
    public class NormalLaptop : ILaptop
    {
        public string Name()
        {
            return "Normal laptop";
        }
    }
}

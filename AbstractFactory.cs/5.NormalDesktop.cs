using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.cs
{
    public class NormalDesktop : IDesktop
    {
        public string Name()
        {
            return "Normal Desktop";
        }
    }
}

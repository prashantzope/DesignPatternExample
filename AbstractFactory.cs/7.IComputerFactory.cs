using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.cs
{
   public interface IComputerFactory
    {
        ILaptop GetLaptop(string laptopType);
        IDesktop GetDesktop(string desktopType);
    }
}

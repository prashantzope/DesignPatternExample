using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.cs
{
    public class ComputerClient
    {
        ILaptop laptop;
        IDesktop desktop;

        public ComputerClient(IComputerFactory computerFactory,string computerType)
        {
            laptop = computerFactory.GetLaptop(computerType);
            desktop = computerFactory.GetDesktop(computerType);
        }

        public string GetLaptopName()
        {
            return laptop.Name();
        }

        public string GetDesktopName()
        {
            return desktop.Name();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.cs
{
    public class DellFactory : IComputerFactory
    {
        public IDesktop GetDesktop(string desktopType)
        {
            switch (desktopType)
            {
                case "gaming":
                    return new GamingDesktop();
                case "normal" :
                    return new NormalDesktop();
                default: throw new ApplicationException(desktopType + "not able to create");
            }
        }

        public ILaptop GetLaptop(string laptopType)
        {
            switch (laptopType.ToLower())
            {
                case "gaming":
                    return new GamingLaptop();
                case "normal":
                    return new NormalLaptop();
                default: throw new ApplicationException(laptopType+ "not able to create");
            }
        }
    }
}

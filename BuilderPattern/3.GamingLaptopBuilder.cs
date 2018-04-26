using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// Gaming laptop builder
    /// </summary>
    public class GamingLaptopBuilder : ILaptopBuilder
    {
        Laptop _laptop = new Laptop();
        public void AddDisplay()
        {

            _laptop.Display = "Full HD Display";
        }

        public void AddGraphicsCard()
        {
            _laptop.GraphicsCard = "NVidia GeForce";
        }

        public void AddModelNumber()
        {
            _laptop.ModelNumber = "Gaming0001";
        }

        public void AddRam()
        {
            _laptop.RAM = "16GB";            
        }

        public void AddTouchScreen()
        {
            _laptop.TouchScreen = "Yes";
        }

        public Laptop GetLaptop()
        {
            return _laptop;
        }
    }
}

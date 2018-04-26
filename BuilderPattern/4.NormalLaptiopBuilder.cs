using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// Normal Laptop builder
    /// </summary>
    public class NormalLaptiopBuilder : ILaptopBuilder
    {
        Laptop _laptop = new Laptop();
        public void AddDisplay()
        {
            _laptop.Display = "HD Display";
        }

        public void AddGraphicsCard()
        {
            _laptop.GraphicsCard = "No Graphics Card";
        }

        public void AddModelNumber()
        {
            _laptop.ModelNumber = "SD10123";
        }

        public void AddRam()
        {
            _laptop.RAM = "8GB";
        }

        public void AddTouchScreen()
        {
            _laptop.TouchScreen = "NO";
        }

        public Laptop GetLaptop()
        {
            return _laptop;
        }
    }
}

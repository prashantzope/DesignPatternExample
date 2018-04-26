using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// Builder design pattern
    /// </summary>
   public interface ILaptopBuilder
    {
        void AddModelNumber();
        void AddDisplay();
        void AddRam();
        void AddGraphicsCard();
        void AddTouchScreen();

        Laptop GetLaptop();
    }
}

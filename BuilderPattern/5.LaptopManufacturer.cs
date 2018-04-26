using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class LaptopManufacturer
    {
		public void BuildLaptop(ILaptopBuilder laptopBuilder)
        {
            laptopBuilder.AddModelNumber();
            laptopBuilder.AddDisplay();
            laptopBuilder.AddRam();
            laptopBuilder.AddGraphicsCard();
            laptopBuilder.AddTouchScreen();			
            
        }
    }
}

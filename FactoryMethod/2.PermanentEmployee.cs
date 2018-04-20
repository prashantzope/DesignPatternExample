using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PermanentEmployee : IFactory
    {
        public void Details()
        {
            Console.WriteLine("This is permanent employee type object");
        }
    }

}

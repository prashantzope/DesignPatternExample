using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class TemporaryEmployee : IFactory
    {
        public void Details()
        {
            Console.WriteLine("This is temporary employee type object");
        }
    }
}

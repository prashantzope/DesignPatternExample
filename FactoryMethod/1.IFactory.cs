using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //Gang of Four(GoF) definition:
      //  “Define an interface for creating an object, but let subclasses decide which class to instantiate.”
    //IProduct interface
    public interface IFactory
    {
        void Details();
    }
}

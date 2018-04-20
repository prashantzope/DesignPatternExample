using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteEmployeeFactory : EmployeeFactory
    {
        public override IFactory Factory(string employeetype)
        {
            switch (employeetype)
            {
                case "PermanentEmployee":
                    return new PermanentEmployee();
                case "TemporaryEmployee":
                    return new TemporaryEmployee();
                default:
                    throw new ApplicationException(string.Format("This type of employee can not be created"));
            }
        }
    }
}

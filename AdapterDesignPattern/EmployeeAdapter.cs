using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class EmployeeAdapter : ThirdPartyEmployee, ITarget
    {
        public IList<string> GetEmployee()
        {
            return GetEmployees();
        }
    }
}

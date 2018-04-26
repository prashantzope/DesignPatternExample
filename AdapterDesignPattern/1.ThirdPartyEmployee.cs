using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    /// <summary>
    /// Third party employee
    /// </summary>
    public class ThirdPartyEmployee
    {
        public IList<string> GetEmployees()
        {
            IList<string> _employee = new List<string>();
            _employee.Add("Sam");
            _employee.Add("Jhon");
            return _employee;
        }
        
        
    }
}

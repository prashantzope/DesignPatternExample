using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    public class TemporaryEmployee : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string EmployeeType { get; set; }
        public IEmployee Clone()
        {
            return this.MemberwiseClone() as IEmployee;
        }
    }
}

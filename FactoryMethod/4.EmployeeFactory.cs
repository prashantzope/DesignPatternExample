﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class EmployeeFactory
    {
        public abstract IFactory Factory(string employeetype);
    }
}

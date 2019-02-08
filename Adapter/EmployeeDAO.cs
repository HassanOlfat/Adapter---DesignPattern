using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
   public class EmployeeDAO
    {
        public int Save(Employee employee)
        {
            return employee.Id;
        }
    }
}

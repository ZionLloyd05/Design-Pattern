using Services.Creational.Factories.SimpleFactory.Concrete;
using Services.Creational.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Creational.Factories.SimpleFactory.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int empTypeId)
        {
            IEmployeeManager returnValue = null;
            
            if(empTypeId == 1)
            {
                returnValue = new PermanentEmployeeManager();
            }

            else if(empTypeId == 2)
            {
                returnValue = new ContractEmployeeManager();
            }

            return returnValue;
        }
    }
}

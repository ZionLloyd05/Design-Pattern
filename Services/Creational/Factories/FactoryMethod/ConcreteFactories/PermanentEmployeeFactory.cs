using Services.Creational.Factories.FactoryMethod.Managers;
using Services.Creational.Interface;
using Services.Models;

namespace Services.Creational.Factories.FactoryMethod.ConcreteFactories
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseRentAllowance();
            return manager;
        }
    }
}

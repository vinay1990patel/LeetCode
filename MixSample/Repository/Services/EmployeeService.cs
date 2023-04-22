using MixSample.DbContextLayer;
using MixSample.Model;
using System.Collections;
namespace MixSample.Repository.Services
{
    public class EmployeeService : IEmployee
    {

        public readonly Employee employee;
        public  MixedDbContext contextLayer;
          public EmployeeService()
        {
            contextLayer = new  MixedDbContext();
            employee = new Employee();
        }

        public IEnumerable<Employee> GetEmployee()
        {

            IEnumerable<Employee> result = contextLayer.employees.ToArray();

            return result;
        }

        public Employee GetEmployeeByID(int id)
        {
            Employee emp = (Employee) contextLayer.employees.Where(x => x.Id == id);
            return emp;
        }

        public void Save()
        {
            contextLayer.SaveChanges();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MixSample.DbContextLayer;
using MixSample.Model;
using System.Collections;
namespace MixSample.Repository.Services
{
    public class EmployeeService : IEmployee
    {

        //public readonly Employee employee;
        public  MixedDbContext _contextLayer;
        //List<Employee> employees = new List<Employee>();
        public EmployeeService( MixedDbContext mixedDbContext)
        {
            _contextLayer = mixedDbContext;
           // employee = new Employee();
            
        }


     

        public IQueryable<Employee> GetEmployee()
        {
            IQueryable<Employee> employees =_contextLayer.employees.AsQueryable();
             return employees;
        }

        public Employee GetEmployeeByID(int id)
        {
            Employee emp = (Employee)_contextLayer.employees.Where(x => x.Id == id);
            return emp;
        }

        public void Save()
        {
          //  _contextLayer.Entry(employee).State = EntityState.Modified;

            _contextLayer.SaveChanges();
        }

        public void AddEmplopyee(Employee employee)
        {
            _contextLayer.employees.Add(employee);
           //_contextLayer.Entry(employee).State = EntityState.Modified;

        }
    }
}

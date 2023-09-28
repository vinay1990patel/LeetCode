using MixSample.Repository.Interface;
using MixSample.Model;
namespace MixSample.Repository
{
    public interface IEmployee 
    {
      IQueryable <Employee> GetEmployee(); 
        Employee GetEmployeeByID(int id);

        void AddEmplopyee(Employee employee); 

        void Save();
    }
}

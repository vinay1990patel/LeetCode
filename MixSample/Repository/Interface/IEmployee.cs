using MixSample.Repository.Interface;
using MixSample.Model;
namespace MixSample.Repository
{
    public interface IEmployee 
    {
      IEnumerable <Employee> GetEmployee(); 
        Employee GetEmployeeByID(int id);
        void Save();
    }
}

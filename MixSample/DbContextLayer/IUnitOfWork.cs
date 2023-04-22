using MixSample.GenericRepository;
using MixSample.Model;
namespace MixSample.DbContextLayer
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepository<Book> bookGenericRepository { get; }
        IGenericRepository<Employee> employeeGenericRepository { get; }
        void Save();

    }
}

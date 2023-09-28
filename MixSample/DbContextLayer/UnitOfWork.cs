using MixSample.GenericRepository;
using MixSample.Model;

namespace MixSample.DbContextLayer
{
    public class UnitOfWork : IUnitOfWork
    {




        private MixedDbContext _mixedDbContext;

        
        public UnitOfWork(MixedDbContext mixedDbContext) { 
        
           this._mixedDbContext = mixedDbContext;
        }

        public IGenericRepository<Book> _bookGenericRepository;
        public IGenericRepository<Employee> _employeeGenericRepository;
        public IGenericRepository<Book> bookGenericRepository
        {
            get
            {
                if (this._bookGenericRepository == null)
                {
                    this._bookGenericRepository = new GenericRepository<Book>(_mixedDbContext);
                }
                return bookGenericRepository;
            }
        }

        public IGenericRepository<Employee> employeeGenericRepository
        {
            get
            {
                if(this._employeeGenericRepository == null)
                {
                    this. _employeeGenericRepository = new GenericRepository<Employee>(_mixedDbContext);
                }

                return _employeeGenericRepository;
            }
        }


      


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _mixedDbContext.SaveChanges();
        }
    }
}

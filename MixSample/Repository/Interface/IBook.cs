using MixSample.Model;

namespace MixSample.Repository.Interface
{
    public interface IBook
    {

        Task<Book> GetAllBooks();
    }
}

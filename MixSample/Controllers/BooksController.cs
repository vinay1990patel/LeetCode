using Microsoft.AspNetCore.Mvc;
using MixSample.DbContextLayer;
using MixSample.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MixSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private UnitOfWork _unitOfWork = new UnitOfWork();
        
        
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _unitOfWork.bookGenericRepository.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public IEnumerable<Book> Get(int id)
        {
           return _unitOfWork.bookGenericRepository.GetById(id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _unitOfWork.bookGenericRepository.Add(book);
            _unitOfWork.Save();
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book book)
        {
            _unitOfWork.bookGenericRepository.update(book);
            _unitOfWork.Save();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(Book book)
        {
            _unitOfWork.bookGenericRepository.Delete(book);
            _unitOfWork.Save();
        }
    }
}

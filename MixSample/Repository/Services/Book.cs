using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MixSample.DbContextLayer;
using MixSample.Repository.Interface;

namespace MixSample.Repository.Services
{
    public class Book : IBook
    {

        private MixedDbContext _mixedDbContext;
        private IMapper _mapper;
             
        public Book(MixedDbContext mixedDbContext, IMapper mapper) {
            _mixedDbContext = mixedDbContext;
            _mapper = mapper;
        }
        public async Task< Model.Book> GetAllBooks()
        {
            //var result =await _mixedDbContext.books.Select( x => new Model.Book() { 
            //   Id = x.Id,
            //   Title = x.Title,
            //   Author = x.Author,
            //}).ToListAsync();
            var book =   await _mixedDbContext.books.ToListAsync();

            return _mapper.Map<Model.Book>(book);

            // return result;
        }
    }
}

using AutoMapper;
using MixSample.Data;
using MixSample.Model;

namespace MixSample.Helpers
{
    public class ApplicationMapper: Profile
    {
        public ApplicationMapper() {
            CreateMap<BooksData, Book>();
        }
    }
}

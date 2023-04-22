using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MixSample.Controllers
{
   
    [ApiController]
    public class SampleController : ControllerBase
    {

        [Route("get-all")]
        [HttpGet]
        public string GetAll()
        {
            return "response from sample controller";
        }

        [Route("get-data")]
        [HttpGet]
        public string  GetData()
        {
            return "response form sencod GetData Resource";
        }


        [Route("books/getDataById/{id:int:min(10)}")]
        [HttpGet]
       public string GetDataById(int id)
        {
            return id.ToString();
        }




        [Route("books/getDataById/{id}")]
        [HttpPut]
        public string GetDataById(string id)
        {
            return id.ToString();
        }

        [Route("getDataById/{id}/author/{authorId}")]
        [HttpPost]
        public string  GetDataByIdAnTutherID(int id, int AuthorId)
        {
            return id +"f"+ AuthorId;
        }


    }
}

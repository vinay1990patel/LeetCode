using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MixSample.Model;
using MixSample.Repository;
using MixSample.Repository.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MixSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    [Authorize]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployee _employeeService;
        public EmployeeController(IEmployee employee) {
            _employeeService =employee;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public ActionResult < IQueryable<Employee>> Get()
        {

            IQueryable<Employee> result =  _employeeService.GetEmployee().AsQueryable();

            return Ok(result);
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
           _employeeService.AddEmplopyee(employee);

         // var employeeLisr =  _employeeService.GetEmployee();

            _employeeService.Save();

            return Ok();
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


      

    }
}

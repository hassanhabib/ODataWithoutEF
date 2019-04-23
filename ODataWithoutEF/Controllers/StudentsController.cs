using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataWithoutEF.Models;

namespace ODataWithoutEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [EnableQuery()]
        public ActionResult<IEnumerable<Student>> Get()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Hassan Habib",
                    School = new School
                    {
                        Id = Guid.NewGuid(),
                        Name = "Redmond High"
                    }
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Cody Allen",
                    School = new School
                    {
                        Id = Guid.NewGuid(),
                        Name = "Seattle High"
                    }
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Todd Ostermeir",
                    School = new School
                    {
                        Id = Guid.NewGuid(),
                        Name = "Kirkland High"
                    }
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

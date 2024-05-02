using Microsoft.AspNetCore.Mvc;
using Restaurant.model;

namespace Restaurant.Controllers
{
    [ApiController]
    [Route("Person")]
    public class PersonApi : ControllerBase
    {
        public Db_Context dbContextInst;
        public PersonApi(Db_Context dbcontext) {
            this.dbContextInst = dbcontext;

        }
        [HttpPost]
        public IActionResult addPerson(
            [FromBody] Person newPerson
            ) {
            this.dbContextInst.customers.Add(newPerson);
            this.dbContextInst.SaveChanges();
            return Ok(newPerson);

        }

        [HttpGet]
        public List<Person> GetPerson()
        {

            return this.dbContextInst.customers.ToList();

        }

        [HttpDelete("{Personid}")]
        public IActionResult DeletePerson(
             int Personid)
        {
            
            this.dbContextInst.Remove(this.dbContextInst.customers.Find(Personid));
            this.dbContextInst.SaveChanges();
            return Ok();

        }

    }
}

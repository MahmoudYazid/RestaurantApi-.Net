using Microsoft.AspNetCore.Mvc;
using Restaurant.model;

namespace Restaurant.Controllers
{
    [ApiController]
    [Route("menu")]
    public class menuApi : ControllerBase
    {
        private readonly Db_Context _dbContext;


        public menuApi(Db_Context dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<menuItemEntity> Get()
        {


            return _dbContext.menu.ToList(); ;
        }
        [HttpPost]
        public IActionResult Post([FromBody] menuItemEntity newitem)
        {
            

            _dbContext.menu.Add(newitem);
            _dbContext.SaveChanges();
            return Ok("ok");
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
           

            var data =_dbContext.menu.Find(id);
            _dbContext.menu.Remove(data);
            _dbContext.SaveChanges();
            return Ok("ok");
        }
    }
}

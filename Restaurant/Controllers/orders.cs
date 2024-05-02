using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Restaurant.model;
using System.Data.Common;

namespace Restaurant.Controllers
{
    [ApiController]
    [Route("orders")]
    public class orders:ControllerBase
    {
        public Db_Context dbContextInst;
        public orders ( Db_Context dbContextInst) { 
            this.dbContextInst = dbContextInst;
        }
        [HttpGet]
        public List<orderEntity> GetOrders()
        {
            return this.dbContextInst.orders.ToList();
        }

        [HttpPost]
        public IActionResult PostOrders(
            [FromBody] orderEntity newOrder
            )
        {
            this.dbContextInst.orders.Add(newOrder);
            this.dbContextInst.SaveChanges();
            return Ok();
        }


        [HttpDelete("{OrderNeedToBeDeleted}")]
        public IActionResult PostOrders(
            int OrderNeedToBeDeleted
    )
        {
            this.dbContextInst.Remove(this.dbContextInst.orders.Find(OrderNeedToBeDeleted));
            return Ok();
        }
    }
}

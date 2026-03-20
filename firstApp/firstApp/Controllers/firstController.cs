using firstApp.modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
namespace firstApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class firstController : ControllerBase
    {
        List<modalclass> lt;
        public firstController()
        {
            lt = new List<modalclass>()
            {
              new modalclass() {id=1,name="ajith",salary=28000 },
              new modalclass() {id=2,name="aji",salary=28850 }
            
            };
        }
        [HttpGet("{sId}")]

        public IActionResult getresult(int sId)
        {
            var res = lt.Where(x => x.id == sId).ToList();
            return Ok(res);
        }

    }
}

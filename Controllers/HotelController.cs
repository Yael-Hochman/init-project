using Microsoft.AspNetCore.Mvc;
using WebApplication1.CLAS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private static List<Workers> w=new List<Workers> { new Workers {firstname="yael",lastname="hochman",id=1,start= new TimeOnly(08, 12), end =new TimeOnly(14,12) } , new Workers { firstname = "shevi", lastname = "cohen", id = 2, start = new TimeOnly(06, 12), end = new TimeOnly(00, 00) } };

        // GET: api/<HotelController>
        [HttpGet]
        public IEnumerable<Workers> Get()
        {
            return w;
        }

        // GET api/<HotelController>/5
        [HttpGet("{id}")]
        public Workers Get(int id)
        {
            return w[id];
        }

        // POST api/<HotelController>
        [HttpPost]
        public Workers Post([FromBody] Workers p)
        {
          w.Add(p);
            return p;
        }

        // PUT api/<HotelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Workers i)
        {
            int index = w.FindIndex(e => e.id == id); 
            w[index].firstname = i.firstname; 
            w[index].lastname = i.lastname; 
            w[index].start = i.start; 
            w[index].end = i.end;
            w[index].id = i.id;

            
        }

        // DELETE api/<HotelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

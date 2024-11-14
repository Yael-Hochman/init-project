using Microsoft.AspNetCore.Mvc;
using WebApplication1.CLAS;
using WebApplication1.CLASS;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkersController : ControllerBase
    {
        private static DataContext d;
        public WorkersController(DataContext data)
        {
            d = data;
        }
        // GET: api/<HotelController>
        [HttpGet]
        public IEnumerable<Workers> Get()
        {
            return d.worker;
        }

        // GET api/<HotelController>/5
        [HttpGet("{id}")]
        public Workers Get(int id)
        {
            return d.worker[id];
        }

        // POST api/<HotelController>
        [HttpPost]
        public Workers Post([FromBody] Workers p)
        {
            d.worker.Add(p);
            return p;
        }

        // PUT api/<HotelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Workers i)
        {
            int index = d.worker.FindIndex(e => e.id == id);
            d.worker[index].firstname = i.firstname;
            d.worker[index].lastname = i.lastname;
            d.worker[index].start = i.start;
            d.worker[index].end = i.end;
            d.worker[index].id = i.id;


        }

        // DELETE api/<HotelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var index = d.worker.FindIndex(e => e.id.Equals(id));
            d.worker.Remove(d.worker[index]);
        }
    }
}

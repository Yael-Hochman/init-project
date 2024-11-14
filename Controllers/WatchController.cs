using Microsoft.AspNetCore.Mvc;
using WebApplication1.CLAS;
using WebApplication1.CLASS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WatchController : ControllerBase
    {
        private static DataContext d;

        public WatchController(DataContext data)
        {
            d=data;
        }
        // GET: api/<HotelController>
        [HttpGet]
        public IEnumerable<Watch> Get()
        {
            return d.w;
        }

        // GET api/<HotelController>/5
        [HttpGet("{id}")]
        public Watch Get(int code)
        {
            return d.w[code];
        }

        // POST api/<HotelController>
        [HttpPost]
        public Watch Post([FromBody] Watch p)
        {
           d.w.Add(p);
            return p;
        }

        // PUT api/<HotelController>/5
        [HttpPut("{id}")]
        public void Put(int code, [FromBody] Watch i)
        {
            int index = d.w.FindIndex(e => e.code == code);
            d.w[index].code = i.code;
            d.w[index].hourstart = i.hourstart;
            d.w[index].hourfinish = i.hourfinish;
            d.w[index].numofworkers = i.numofworkers;
            d.w[index].manager = i.manager;


        }

        // DELETE api/<HotelController>/5
        [HttpDelete("{id}")]
        public void Delete(int code)
        {
            var index = d.w.FindIndex(e => e.code.Equals(d.w));
            d.w.Remove(d.w[index]);
        }
    }
}

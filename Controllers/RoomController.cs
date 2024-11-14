using Microsoft.AspNetCore.Mvc;
using WebApplication1.CLAS;
using WebApplication1.CLASS;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        // GET: api/<RoomController>
        private static DataContext d;
        public RoomController(DataContext data)
        {
            d= data;
        }
        
        // GET: api/<HotelController>
        [HttpGet]
        public IEnumerable<Rooms> Get()
        {
            return d.r;
        }

        // GET api/<HotelController>/5
        [HttpGet("{id}")]
        public Rooms Get(int number)
        {
            return d.r[number];
        }

        // POST api/<HotelController>
        [HttpPost]
        public Rooms Post([FromBody] Rooms e)
        {
            d.r.Add(e);
            return e;
        }

        // PUT api/<HotelController>/5
        [HttpPut("{id}")]
        public void Put(int number, [FromBody] Rooms i)
        {
            int index = d.r.FindIndex(e => e.number == number);
            d.r[index].number = i.number;
            d.r[index].floor = i.floor;
            d.r[index].free = i.free;
            d.r[index].checkin = i.checkin;
            d.r[index].checkout = i.checkout;


        }

        // DELETE api/<HotelController>/5
        [HttpDelete("{id}")]
        public void Delete(int number)
        {
            var index = d.r.FindIndex(e => e.number.Equals(number));
            d.r.Remove(d.r[index]);
        }
    }
}

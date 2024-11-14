using WebApplication1.CLAS;

namespace WebApplication1.CLASS
{
    public class DataContext
    {
        public List<Rooms> r { get; set; }
        public List<Watch> w { get; set; }
        public List<Workers> worker { get; set; }

        public DataContext()
        {
            r = new List<Rooms> { new Rooms { number = 1, floor = 2, free = true, checkin = new DateOnly(2005, 06, 21), checkout = new DateOnly(2005, 07, 21) } };
            w = new List<Watch> { new Watch { code = 8, hourstart = new DateTime(2006, 06, 06, 08, 21, 00), hourfinish = new DateTime(2006, 07, 06, 09, 51, 21), numofworkers = 3, manager = "yael" } };
            worker = new List<Workers> { new Workers { firstname = "ayelet", lastname = "cohen", id = 123456789, start = new TimeOnly(08, 09), end = new TimeOnly(09, 06) } };
        }



    }


    }


namespace WebApplication1.CLAS
{
    public class Rooms
    {
        public int number { get; set; }
        public int floor { get; set; }
        public Boolean free { get; set; }
        public DateOnly checkin { get; set; }
        public DateOnly checkout { get; set; }
    }
}

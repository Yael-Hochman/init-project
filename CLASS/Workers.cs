using System.Security.Principal;

namespace WebApplication1.CLAS
{
    public class Workers
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int id { get; set; }
        public TimeOnly start { get; set; }
        public TimeOnly end { get; set; }
    }
}

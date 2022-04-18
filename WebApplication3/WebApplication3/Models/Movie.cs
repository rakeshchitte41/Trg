using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string film { get; set; }
        public string genre { get; set; }
        public string leadstudio { get; set; }
        public string audiencescore { get; set; }
        public string profitability { get; set; }
        public string rottentomatoes { get; set; }
        public string worldwisegross { get; set; }


    }





















































}

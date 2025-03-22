using System.ComponentModel.DataAnnotations;

namespace ActivityTracker.Models
{
    public class Activity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }
        public String Date { get; set; }
    }
}

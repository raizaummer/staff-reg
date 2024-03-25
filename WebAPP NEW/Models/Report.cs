using System.ComponentModel.DataAnnotations;

namespace WebAPP_NEW.Models
{
    public class Report
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Designation { get; set; }
        [Required]
        public string Salary { get; set; }
    }
}

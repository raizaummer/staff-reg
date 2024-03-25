using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPP_NEW.Models
{
    public class ERegistration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        [NotMapped]
        public string Fileobj { get; set; }
        
        public string Email { get; set; }
        public string Phone { get; set; }
    }


    }

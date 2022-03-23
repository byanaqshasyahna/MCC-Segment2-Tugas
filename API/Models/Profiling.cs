using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Profiling
    {

        [Key]
        public string NIK { get; set; }

        [Required]
        public int EducationId { get; set; }

        public Account Account { get; set; }
        public Education Education { get; set; }

    }
}

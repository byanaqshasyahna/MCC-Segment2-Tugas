using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Account
    {
		[Key, Required]
		public string NIK { get; set; }

		[Required]
		public string Password { get; set; }
		public Employee Employee { get; set; }
		public Profiling Profiling { get; set; }
	}
}

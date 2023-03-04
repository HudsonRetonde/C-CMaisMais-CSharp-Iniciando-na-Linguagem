using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace FilmesAPI.Models
{
	public class Cinema
	{
		[Key]
		[Required]
		public int Id { get; set; }
		[Required(ErrorMessage ="O campo nome é obrigatório.")]
		public string Nome { get; set; }
	}
}

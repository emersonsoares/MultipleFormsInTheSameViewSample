using System.ComponentModel.DataAnnotations;

namespace MultipleFormsInTheSameViewSample.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite um email")]
        [RegularExpression(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}", ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite uma senha")]
        [MinLength(5, ErrorMessage = "A senha deve ter no máximo 20 caracteres")]
        [MaxLength(20, ErrorMessage = "A senha deve ter no máximo 20 caracteres")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Digite o primeiro nome")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Digite o segundo nome")]
        public string LastName { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace crud.api.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "O Login é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O E-Mail é obrigatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatoria")]
        public string Senha { get; set; }
    }
}

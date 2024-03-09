using System.ComponentModel.DataAnnotations;

namespace DotnetIdentityToken.Core.Models.UserModels
{
    public class RegisterModel
    {
        [StringLength(15)]
        [MaxLength(15)]
        [Required(ErrorMessage = "Primeiro nome é obrigatório")]
        [Display(Name = "Primeiro Nome")]
        public string FirstName { get; set; }
        [StringLength(100)]
        [MaxLength(100)]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }
        [StringLength(15)]
        [MaxLength(15)]
        [Display(Name = "Apelido")]
        public string Surname { get; set; } = string.Empty;
        [StringLength(15)]
        [MaxLength(15)]
        [Required(ErrorMessage = "Nome de usuário é obrigatório")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Senha é obrigatório")]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirme sua senha")]
        [Compare("Password", ErrorMessage = "A senha e a senha de confirmação não coincidem.")]
        public string ConfirmPassword { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace DotnetIdentityToken.Core.Models.UserModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Nome de usuário é obrigatório")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Senha é obrigatório")]
        [Display(Name = "Senha")]
        public string Password { get; set; }
        [Display(Name = "Manter conectado")]
        public bool RememberMe { get; set; }
    }
}

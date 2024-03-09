using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DotnetIdentityToken.Data.Data
{
    public class User : IdentityUser
    {
        [StringLength(15)]
        [MaxLength(15)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string LastName { get; set; }
        [StringLength(15)]
        [MaxLength(15)]
        public string Surname { get; set; } = string.Empty;
    }
}

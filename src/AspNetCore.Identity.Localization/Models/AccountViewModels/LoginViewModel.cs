using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Identity.Localization.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "The Email is required.")]
        [EmailAddress(ErrorMessage = "The Email is not a valid e-mail address.")]
        public string Email { get; set; }

        [Required(ErrorMessage ="The Username is required.")]
        public string Username { get; set; }

        [Required(ErrorMessage ="The Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}

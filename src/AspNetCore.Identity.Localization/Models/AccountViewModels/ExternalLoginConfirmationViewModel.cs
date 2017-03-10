using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Identity.Localization.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

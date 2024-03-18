using System.ComponentModel.DataAnnotations;

namespace ASPBlog.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Vyplňte emailovou adresu")]
        [EmailAddress(ErrorMessage = "Neplatný formát emailové adresy")]
        [Display(Name = "Emailová adresa")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Vyplňte heslo")]
        [StringLength(100, ErrorMessage = "{0} musí mít alespoň {2} a maximálně {1} znaků", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; } = "";

        [Required(ErrorMessage = "Potvrďte heslo")]
        [DataType(DataType.Password)]
        [Display(Name = "Potvrzení hesla")]
        [Compare(nameof(Password), ErrorMessage ="Hesla se neshodují.")]
        public string ConfirmPassword { get; set; } = "";


    }
}

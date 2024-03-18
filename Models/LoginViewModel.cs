using System.ComponentModel.DataAnnotations;

namespace ASPBlog.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage ="Vyplntě emailovou adresu")]
        [EmailAddress(ErrorMessage ="Neplatný formát emailové adresy")]
        [Display(Name ="Emailová adresa")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Vyplňte heslo")]
        [DataType(DataType.Password)]
        [Display(Name ="Heslo")]
        public string Password { get; set; }

        [Display(Name ="Zapamatovat si mě")]
        public bool RememberMe { get; set; }




    }
}

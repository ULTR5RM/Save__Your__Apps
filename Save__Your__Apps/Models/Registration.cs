using System.ComponentModel.DataAnnotations;
namespace Save__Your__Apps.Models
{
    public class Registration
    {
        public class RegUser : User
        {
            [Required]
            [Compare("Password", ErrorMessage = "Пароли не совпадают.")]
            [DataType(DataType.Password)]
            [Display(Name = "Подтвердить пароль")]
            public string ConPassword { get; set; } = "";
        }
    }
}

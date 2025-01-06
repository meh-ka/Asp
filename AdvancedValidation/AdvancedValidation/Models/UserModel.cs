using System.ComponentModel.DataAnnotations;

namespace AdvancedValidation.Models
{
    public class UserModel
    {
        [Display(Name = "شماره ویژ")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [Display(Name = "نام")]
        public string? Name { get; set; }

        [Display(Name ="ایمیل")]
        [Required(ErrorMessage = "les chambres obligatoir {0} n'sont pas rampli ")]
        [EmailAddress(ErrorMessage = "قالب{0} اشتباه است")]
        public string? Email { get; set; }

        [Display(Name = "سن")]
        [Range(18, 50, ErrorMessage = "limite d'{0} entre {1}-{2}")]
        public int  Age { get; set; }

        [Display(Name = "تلفن")]
        [RegularExpression(@"^(01|02|03|04|05|09)([ -]?[0-9]{2}){4}$", ErrorMessage = "Le format du {0} est incorrect.")]
        public string? PhoneFix { get; set; }

        [Display(Name = "موبایل")]
        //[RegularExpression("09(1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}", ErrorMessage = "قالب {0} اشتباه است")]
        [RegularExpression(@"^(06|07)([ -]?[0-9]{2}){4}$", ErrorMessage = "Le format du {0} est incorrect.")]
        public string? PhoneNumber { get; set; }

        [Display(Name = "توضیحات")]
        [StringLength(6, MinimumLength = 3, ErrorMessage = "characters should not be less than 3 and more than 6")]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }

        [Display(Name = "رمز")]
        [Required(ErrorMessage = "les chambres obligatoir {0} n'sont pas rampli ")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "تکرار رمز")]
        [Required(ErrorMessage = "les chambres obligatoir {0} n'sont pas rampli ")]
        [Compare("Password", ErrorMessage = "تکرار رمز عبور صحیح نمیباشد.")]
        [DataType(DataType.Password)]
        public string? Repassword { get; set; }
      








    }
}

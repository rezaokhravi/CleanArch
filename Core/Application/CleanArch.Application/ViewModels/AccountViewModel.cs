using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels {

    public class RegisterViewModel {
        [Display (Name = "نام کاربری")]
        [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string UserName { get; set; }

        [Display (Name = "ایمیل")]
        [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        [EmailAddress (ErrorMessage = "{0} وارد شده معتبر نمی باشد")]
        public string Email { get; set; }

        [Display (Name = "کلمه عبور")]
        [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]

        public string Password { get; set; }

        [Display (Name = "تکرار کلمه عبور")]
        [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        [Compare (nameof (Password),ErrorMessage ="کلمه عبور با {0} مقایرت دارد")]
        public string RePassword { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.ViewModels {
    public class UserViewModel {
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

        [Display (Name = "تصویر کاربر")]
        public string UserAvatar { get; set; }

        [Display (Name = "تاریخ ثبت نام")]

        public DateTime RegisterDate { get; set; }

    }
}
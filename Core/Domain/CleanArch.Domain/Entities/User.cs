using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities {
    public class User {
        public User () {

        }

        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [Display (Name = "نام کاربری")]
        [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string UserName { get; set; }

        [Display (Name = "کلمه عبور")]
        [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string Password { get; set; }

        [Display (Name = "نام قابل نمایش")]
        [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string DisplayName { get; set; }

        [Display (Name = "وضعیت")]
        public bool IsActive { get; set; }

        [Display (Name = "تصویر کاربر")]
        public byte? UserAvatar { get; set; }

        [Display (Name = "تاریخ آخرین لاگین")]

        public DateTime? LastLoginDate { get; set; }

        #region Relations
        public virtual List<UserRole> UserRoles { get; set; }
        #endregion

    }
}
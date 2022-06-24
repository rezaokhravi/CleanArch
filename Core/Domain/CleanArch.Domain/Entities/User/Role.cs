using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities.User {
    public class Role {
        public Role () { }

        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }

        [Display (Name = "")]
        [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
        public string RoleTitle { get; set; }

        #region Relations
        public virtual List<UserRole> UserRoles { get; set; }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities.User {
    public class UserRole {
        public UserRole () { }

        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int UserRoleId { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }

        #region Relations
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
        #endregion        
    }
}
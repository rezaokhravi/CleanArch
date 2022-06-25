using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Entities;

public class TeamRole
{
    public TeamRole()
    {
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TeamRoleId { get; set; }
    [Display (Name = "نام نقش تیم")]
    [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
    public string Name { get; set; }
    [Display (Name = "عنوان نقش تیم")]
    [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
    [MaxLength (200, ErrorMessage = "{0} نمی تواند بیشتر از {1} باشد")]
    public string Title { get; set; }
}
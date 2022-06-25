using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Entities;

public class ProjectMember
{
    public ProjectMember()
    {
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProjectMemberId { get; set; }

    public int ProjectId { get; set; }
    public int EmployeeId { get; set; }
    public int TeamRoleId { get; set; }
}
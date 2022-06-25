using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Entities;

public class Form
{
    public Form()
    {
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int FromId { get; set; }

    public string Title { get; set; }
    public int TeamRoleId { get; set; }
    public string Type { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Entities;

public class EvaluateForm
{
    public EvaluateForm()
    {
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EvaluateFormId { get; set; }

    public int EvaluateId { get; set; }
    public int FormId { get; set; }
    public int MemberId { get; set; }
    public int ProjectMemberId { get; set; }
    public string Description { get; set; }
    public DateTime ModifyAt { get; set; }
}
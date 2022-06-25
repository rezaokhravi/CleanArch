using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Entities;

public class Evaluate
{
    public Evaluate()
    {
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EvaluateId { get; set; }

    public int ProjectId { get; set; }
    public string Description { get; set; }
    public short Status { get; set; }
    public string StepName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
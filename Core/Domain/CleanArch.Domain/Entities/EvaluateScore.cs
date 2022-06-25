using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Entities;

public class EvaluateScore
{
    public EvaluateScore()
    {
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EvaluateScoreId { get; set; }

    public int EvaluateFormId { get; set; }
    public int QuestionId { get; set; }
    public float Score { get; set; }
}
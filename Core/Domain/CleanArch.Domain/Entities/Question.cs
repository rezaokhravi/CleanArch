using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Entities;

public class Question
{
    public Question()
    {
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int QuestionId { get; set; }
    [Display (Name = "شناسه فرم ارزشیابی")]
    public int FromId { get; set; }
    [Display (Name = "عنوان سوال")]
    [Required (ErrorMessage = "لطفا {0} را وارد نمایید")]
    public string Questions { get; set; }
    [Display (Name = "نوع سوال")]
    public short ScoreType { get; set; }
}
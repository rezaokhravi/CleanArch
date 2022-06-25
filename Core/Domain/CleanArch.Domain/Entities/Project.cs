using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Domain.Entities;

public class Project
{
    public Project()
    {
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProjectId { get; set; }

    public string Title { get; set; }
    public string JiraProjectKey { get; set; }
    public string ConfluenceUrl { get; set; }
    public short QualityLevel { get; set; }
    public short PriorityLevel { get; set; }
    public short ImportanceLevel { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public short ProjectType { get; set; }
    public short Status { get; set; }
}
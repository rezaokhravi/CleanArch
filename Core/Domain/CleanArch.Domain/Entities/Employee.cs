using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    public class Employee
    {
        public Employee()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public int UserId { get; set; }
        public string PersonnelCode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string TechTeam { get; set; }
        public string TechRole { get; set; }
        public string Skills { get; set; }
        public string SkillLevel { get; set; }
        public string Job { get; set; }
        public string JobLevel { get; set; }
    }
}
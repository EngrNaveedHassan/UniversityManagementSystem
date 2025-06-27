using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Subject
    {
        [Key]
        public required string SubjectCode { get; set; }
        public required string SubjectName { get; set; }
        public required int Credits { get; set; }
        public string? Description { get; set; }
    }
}

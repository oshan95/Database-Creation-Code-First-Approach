using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach
{
    public class Subject
    {
        [Key, Column(Order=1)]
        public string SubjectName { get; set; }
        [Key, Column(Order = 0)]
        public string SubjectCode { get; set; }

        [Required]
        public virtual student student { get; set; }
    }
}

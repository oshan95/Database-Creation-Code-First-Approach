using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach
{
    public class faculty
    {
        [Key]
        public string  FacultyName { get; set; }
        public string Dean { get; set; }
        public int NoOfStudents { get; set; }

       // public virtual List<student> Students { get; set; }

        public faculty()
        {
            //this.Students = new List<student>();
        }
    }
}

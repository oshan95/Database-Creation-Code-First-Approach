using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproach
{
    class Patient
    {
        public Patient()
        {
            this.Addresses = new List<PatientAddress>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [MaxLength(1)]
        public string Gender { get; set; }

        [MaxLength(10)]
        public string ContactNo { get; set; }

        public virtual PatientAddress Address { get; set; }

        public virtual IList<PatientAddress> Addresses { get; set; }
    }
}

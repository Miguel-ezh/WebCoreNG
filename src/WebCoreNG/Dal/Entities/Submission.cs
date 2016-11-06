using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreNG.Dal.Entities
{
    public class Submission
    {
        [Key]
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Network { get; set; }

        [Required]
        [StringLength(50)]
        public string SentEmail { get; set; }

        [Required]
        public DateTime ExpireDate { get; set; }

        public virtual ICollection<SubmissionAccountLookup> SubmissionAccountLookups { get; set; }
    }
}

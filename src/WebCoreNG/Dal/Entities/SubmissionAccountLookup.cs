using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCoreNG.Dal.Entities
{
    public class SubmissionAccountLookup
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string SubmissionId { get; set; }

        [ForeignKey("SubmissionId")]
        public virtual Submission Submission { get; set; }

        [Required]
        public int AccountId { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }


    }
}
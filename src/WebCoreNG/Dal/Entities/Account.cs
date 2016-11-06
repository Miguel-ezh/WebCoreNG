using System;
using System.ComponentModel.DataAnnotations;

namespace WebCoreNG.Dal.Entities
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(500)]
        public string Url { get; set; }

        [Required]
        public long AlexaRank { get; set; }

        [Required]
        public string Country { get; set; }
    }
}

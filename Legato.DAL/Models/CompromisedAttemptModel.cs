using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("CompromisedAttempts")]
    public class CompromisedAttemptModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttemptId { get; set; }

        [Required]
        public string CompromisedToken { get; set; }

        public string RequestIP { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public DateTime RequestDateTime { get; set; }
    }
}

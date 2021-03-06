﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Legato.DAL.Models
{
    [Table("TokenStorage")]
    public class TokenModel
    {
        [Key]
        [StringLength(256)]
        public string Token { get; set; }

        [Required]
        public string IssuedTo { get; set; }

        [Required]
        public DateTime Expiry { get; set; }
    }
}

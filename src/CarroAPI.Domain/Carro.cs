using System;
using System.ComponentModel.DataAnnotations;

namespace CarroAPI.Domain
{
    public sealed class Carro : Entity
    {
        [Required]
        [MaxLength(15)]
        [MinLength(2)]
        public string ano { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(2)]
        public string marca { get; set; }

        [Required]
        [MaxLength(15)]
        [MinLength(2)]
        public string modelo { get; set; }
        
    }
}
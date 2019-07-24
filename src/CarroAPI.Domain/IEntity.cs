using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarroAPI.Domain
{
    public interface IEntity
    {
        [Required]
        Guid key { get; }
    }
}

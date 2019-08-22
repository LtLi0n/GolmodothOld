using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Shared.Golmodoth
{
    [Owned]
    public class Position
    {
        [Required]
        public short X { get; set; } = 0;

        [Required]
        public short Y { get; set; } = 0;
        
        [Required]
        public uint MapId { get; set; }
        
        [JsonIgnore, IgnoreDataMember]
        public Map Map { get; set; }
    }
}

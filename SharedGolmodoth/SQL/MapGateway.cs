using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using LionLibrary.SQL;

namespace Shared.Golmodoth
{
    [Table("maps_gateways")]
    public class MapGateway : IEntity<MapGateway, uint>
    {
        [Key]
        public uint Id { get; set; }

        [Required]
        public Position TeleportPosition { get; set; }
        
        [Required]
        public uint DestinationMapId { get; set; }

        [JsonIgnore, IgnoreDataMember]
        public Map DestinationMap { get; set; }
    }
}

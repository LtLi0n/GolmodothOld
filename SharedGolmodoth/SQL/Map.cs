using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using LionLibrary.SQL;
using Microsoft.EntityFrameworkCore;

namespace Shared.Golmodoth
{
    [Table("maps")]
    public class Map : IEntity<Map, uint>
    {
        [Key]
        public uint Id { get; set; }

        [Column("nvarchar(255)"), Required]
        public string Name { get; set; }

        [Column("nvarchar(255)"), Required]
        public string CodeName { get; set; }

        [MaxLength(2048)]
        public string Description { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }

        ///<summary>One to Many.</summary>
        public ICollection<MapGateway> Gateways { get; set; }
        public ushort[] Tiles { get; set; }

        public ushort this[int x, int y] => Tiles[y * Width + x];

        public static void RegisterEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Map>(x =>
            {
                x.HasIndex(map => map.Name).IsUnique();
                x.HasIndex(map => map.CodeName).IsUnique();

                x.OwnsMany(map => map.Gateways)
                .HasForeignKey(gateway => gateway.TeleportPosition.MapId);
            });
        }
    }
}

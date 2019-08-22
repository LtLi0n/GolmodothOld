using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LionLibrary.SQL;
using Microsoft.EntityFrameworkCore;

namespace Shared.Golmodoth
{
    [Table("players")]
    public class Player: IEntity<Player, uint>
    {
        [Key]
        public uint Id { get; set; }

        [MaxLength(32)]
        public string Username { get; set; }

        [Required]
        public ulong Currency { get; set; } = 0;

        public Position Position { get; set; }

        public static void RegisterEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(x =>
            {
                x.HasIndex(map => map.Username).IsUnique();
            });
        }
    }
}

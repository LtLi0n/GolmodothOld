using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LionLibrary.SQL;

namespace Shared.Golmodoth
{
    [Table("tiles")]
    public class Tile : IEntity<Tile, ushort>
    {
        [Key]
        public ushort Id { get; set; }

        public byte Color { get; set; }
        public char Glyph { get; set; }
        public bool Walkable { get; set; } = true;
    }
}

using System.Collections.Generic;
using Shared.Golmodoth;

using static ConsoleGameEngine.ColorPalettes.PaletteColorContainer_DefaultWindowsScheme;

namespace Golmodoth
{
    public class TileContainer : StaticEntityContainerBase<Tile, ushort>
    {
        protected override IEnumerable<Tile> LoadContent() =>
            new Tile[]
            {
                new Tile{ Id = GRASS, Color = BG_GREEN, Glyph = ' ' },
                new Tile{ Id = WATER, Color = BG_CYAN, Glyph = ' ', Walkable = false }
            };

        public const ushort GRASS = 1;
        public const ushort WATER = 2;
    }
}

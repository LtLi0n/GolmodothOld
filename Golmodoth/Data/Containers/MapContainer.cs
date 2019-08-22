using System.Collections.Generic;
using Shared.Golmodoth;

using tile = Golmodoth.TileContainer;

namespace Golmodoth
{
    public class MapContainer : StaticEntityContainerBase<Map, uint>
    {
        protected override IEnumerable<Map> LoadContent() =>
            new Map[]
            {
                StartingMap()
            };

        private Map StartingMap()
        {
            Map map = new Map
            {
                Id = 1,
                Name = "Test Area",
                CodeName = "area:51",
                Description = "naturo runners will dodge my coding skills",
                Width = 20,
                Height = 20,
                Tiles = new ushort[20 * 20]
                {
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.WATER, tile.WATER, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.WATER, tile.GRASS, tile.GRASS, tile.WATER, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.WATER, tile.GRASS, tile.GRASS, tile.WATER, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.WATER, tile.WATER, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.WATER, tile.WATER, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS,
                    tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS, tile.GRASS
                }
            };

            map.Gateways = new MapGateway[]
            {
                new MapGateway
                { 
                    TeleportPosition = new Position
                    {
                        Map = map,
                        MapId = map.Id,
                        X = 5,
                        Y = 5
                    } 
                }
            };

            return map;
        }
    }
}

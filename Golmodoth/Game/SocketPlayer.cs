using System;
using Microsoft.Extensions.DependencyInjection;
using Shared.Golmodoth;
using System.Collections.Generic;
using System.Text;
using ConsoleGameEngine;
using LionLibrary.Network;

using static ConsoleGameEngine.ColorPalettes.PaletteColorContainer_DefaultWindowsScheme;

namespace Golmodoth
{
    //Add multiplayer later
    public class SocketPlayer : Player, IEngineObject
    {
        private readonly ConsoleGame _game;
        private ConsoleEngine Engine => _game.Engine;

        private readonly LionClient _client;
        private readonly IServiceProvider _services;

        private DateTime _lastMoved;

        public Map CurrentMap => _services
            .GetService<EntityDataService>()
            .GetContainer<MapContainer>()[base.Position.MapId];

        public TileContainer Tiles => _services
            .GetService<EntityDataService>()
            .GetContainer<TileContainer>();

        public SocketPlayer(LionClient client, ConsoleGame game, Player player, IServiceProvider services)
        {
            _client = client;
            _game = game;

            base.Id = player.Id;
            base.Username = player.Username;
            base.Position = player.Position;
            base.Currency = player.Currency;

            _services = services;
        }

        public void Update()
        {
            //Movement
            {
                if (Engine.GetKey(ConsoleKey.W) || Engine.GetKey(ConsoleKey.UpArrow)) Move(Direction.North);
                if (Engine.GetKey(ConsoleKey.D) || Engine.GetKey(ConsoleKey.RightArrow)) Move(Direction.East);
                if (Engine.GetKey(ConsoleKey.S) || Engine.GetKey(ConsoleKey.DownArrow)) Move(Direction.South);
                if (Engine.GetKey(ConsoleKey.A) || Engine.GetKey(ConsoleKey.LeftArrow)) Move(Direction.West);
            }

        }

        public void Render()
        {
            RenderMap(CurrentMap);
            Engine.SetPixel(new Point(base.Position.X, base.Position.Y), FG_BLUE + BG_DARK_BLUE, '*');

            Engine.WriteText(new Point(1, Console.BufferHeight - 1), $"{CurrentMap.CodeName} [x:{base.Position.X}, y:{base.Position.Y}]", FG_WHITE);
        }

        //move this somewhere else
        public void RenderMap(Map map)
        {
            //where is my camera :(
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Tile tile = Tiles[map.Tiles[y * map.Width + x]];
                    Engine.SetPixel(new Point(x, y), tile.Color, tile.Glyph);
                }
            }
        }

        public void Move(Direction direction)
        {
            if(Engine.HasFocus)
            {
                if (DateTime.Now - _lastMoved >= TimeSpan.FromMilliseconds(100))
                {
                    short x = base.Position.X;
                    short y = base.Position.Y;

                    switch (direction)
                    {
                        case Direction.North: y--; break;
                        case Direction.East: x++; break;
                        case Direction.South: y++; break;
                        case Direction.West: x--; break;
                    }

                    if (Tiles[CurrentMap[x, y]].Walkable)
                    {
                        base.Position.X = x;
                        base.Position.Y = y;
                    }

                    _lastMoved = DateTime.Now;
                }
            }
        }
    }
}

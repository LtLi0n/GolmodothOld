using System;
using System.Collections.Generic;
using System.Text;
using ConsoleGameEngine;
using Shared.Golmodoth;

using static ConsoleGameEngine.ColorPalettes.PaletteColorContainer_DefaultWindowsScheme;

namespace Golmodoth.Engine
{
    public class ConsoleWindow : ConsoleGame, IEngineObject
    {
        private readonly IServiceProvider _services;
        public List<IEngineObject> EngineObjects { get; }

        public ConsoleWindow(IServiceProvider services)
        {
            _services = services;

            EngineObjects = new List<IEngineObject>
            {
                new SocketPlayer(
                    client: null,
                    game: this,
                    player: new Player
                    {
                        Id = 1,
                        Username = "LtLi0n",
                        Currency = 10,
                        Position = new Position { MapId = 1, X = 9, Y = 9 }
                    },
                    services: _services)
            };
        }

        public override void Create()
        {
            Console.Title = "Golmodoth";
            Engine.SetPalette(PaletteColor.Containers.Default);
            //Engine.Borderless();
        }

        public override void Update()
        {
            EngineObjects.ForEach(x => x.Update());
        }

        public override void Render()
        {
            Engine.ClearBuffer();
            EngineObjects.ForEach(x => x.Render());
            Engine.DisplayBuffer();
        }
    }
}

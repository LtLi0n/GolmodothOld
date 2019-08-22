using System;
using System.Collections.Generic;
using System.Text;
using ConsoleGameEngine;
using static ConsoleGameEngine.ColorPalettes.PaletteColorContainer_DefaultWindowsScheme;

namespace Golmodoth.Engine
{
    public class ConsoleWindow : ConsoleGame
    {
        public ConsoleWindow()
        {

        }

        public override void Create()
        {
            Engine.SetPalette(PaletteColor.Containers.Default);
            Engine.Borderless();
        }

        public override void Render()
        {
            Engine.ClearBuffer();
            Engine.WriteText(new Point(3, 3), "Hello World", FG_GREEN + BG_DARK_BLUE);
            Engine.DisplayBuffer();
        }

        public override void Update()
        {

        }
    }
}

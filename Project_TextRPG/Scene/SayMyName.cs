using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    internal class SayMyName : Scene
    {
        Sprites sprites = new Sprites();
        PlayerState playerState = new PlayerState();
        public SayMyName(Game game) : base(game)
        {
        }
        public override void Render()
        {
            sprites.Remove();
            sprites.PlayerDefault();
            System.Threading.Thread.Sleep(1000);
        }

        public override void Update()
        {
            ConsoleKeyInfo input = Console.ReadKey();
        }
    }
}

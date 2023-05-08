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
        public SayMyName(Game game) : base(game)
        {
        }
        public override void Render()
        {
            sprites.Remove();
            
        }

        public override void Update()
        {
            sprites.PlayerDefault();
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(5, 18);
            Console.WriteLine("내 이름은...");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(20, 18);
            Console.WriteLine($"{PlayerState.name}...!!!");
            System.Threading.Thread.Sleep(1000);
            sprites.Remove();
            sprites.PlayerDefault();
            Console.SetCursorPosition(5, 18);
            Console.WriteLine("마왕을 죽이러 가야겠어");
            System.Threading.Thread.Sleep(1000);
            game.Field();
            return;
        }
    }
}

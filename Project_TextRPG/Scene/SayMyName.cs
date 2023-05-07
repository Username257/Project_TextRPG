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
            sprites.PlayerDefault();
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(5, 18);
            Console.WriteLine("내 이름은...");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(20, 18);
            Console.WriteLine($"{PlayerState.name}...!!!");
            
        }

        public override void Update()
        {
            ConsoleKeyInfo input = Console.ReadKey();
        }
    }
}

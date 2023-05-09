using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    internal class Win : Scene
    {
        Sprites sprites = new Sprites();
        public Win(Game game) : base(game)
        {
        }
        public override void Render()
        {
            sprites.Remove();
            Console.SetCursorPosition(25, 22);
            Console.WriteLine("이겼다!");
            Console.SetCursorPosition(25, 23);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("이렇게 평화가 찾아오는 듯 했으나...");
            Console.SetCursorPosition(25, 24);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("이세계는 원래 평화로웠다!");
            Console.SetCursorPosition(25, 26);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("- 끝 - ");
            
        }

        public override void Update()
        {
            
        }
    }
}

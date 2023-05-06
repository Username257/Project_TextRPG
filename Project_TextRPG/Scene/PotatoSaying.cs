using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    internal class PotatoSaying : Scene
    {
        Sprites sprites = new Sprites();
        
        public PotatoSaying(Game game) : base(game)
        {
        }
        public override void Render()
        {
            sprites.Crown();
            sprites.SleepyingPotato();
            sprites.Bar();
        }

        public override void Update()
        {
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(65, 3);
            Console.WriteLine("쿨");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(69, 5);
            Console.WriteLine("쿨");
            System.Threading.Thread.Sleep(1000);

            Console.SetCursorPosition(20, 19);
            Console.WriteLine("일어나! 이 감자 마왕!");

            System.Threading.Thread.Sleep(1000);

            sprites.Remove();

            sprites.Crown();
            sprites.Potato();

            System.Threading.Thread.Sleep(1000);
            //말풍선 안에 21자
            sprites.SpeechBubbleForPotato();

            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(75, 3);
            Console.WriteLine("너냐! 이 몸의");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(75, 4);
            Console.WriteLine("잠을 깨운 것이!");
            Console.SetCursorPosition(0, 23);
            System.Threading.Thread.Sleep(1000);

            Console.SetCursorPosition(20, 19);
            Console.WriteLine("결투다아아앗!!!!!!!!!!!");
            System.Threading.Thread.Sleep(1000);

            sprites.Fight();
        }
    }
}

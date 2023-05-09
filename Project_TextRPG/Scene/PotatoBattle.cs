using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    public class PotatoBattle : Scene
    {
        Sprites sprites = new Sprites();
        bool goNextScene = false;
        public PotatoBattle(Game game) : base(game)
        {
        }
        public override void Render()
        {
            

            sprites.Remove();
            sprites.Crown();
            sprites.Potato();
            Console.SetCursorPosition(25, 22);
            Console.WriteLine("【 공격 】           【 아이템 】         【 도망가기 】");

            Console.SetCursorPosition(30, 13);
            Console.Write($"감자마왕 hp : {PotatoState.hp}");

            Console.SetCursorPosition(25, 20);
            Console.Write($"{PlayerState.name} hp : {PlayerState.hp}");
        }

        public override void Update()
        {
            if (goNextScene)
            {
                game.Win();
                return;
            }

            int choice = 0;

            while (true)
            {
                if (choice == 0)
                {
                    Remove();
                    Console.SetCursorPosition(30, 21);
                }
                else if (choice == 1)
                {
                    Remove();
                    Console.SetCursorPosition(50, 21);
                }
                else
                {
                    Remove();
                    Console.SetCursorPosition(70, 21);
                }

                Console.Write(" ▼");
                Console.SetCursorPosition(0, 30);

                while (Console.KeyAvailable)
                    Console.ReadKey(false);

                ConsoleKeyInfo input = Console.ReadKey();

                if (input.Key == ConsoleKey.RightArrow)
                    choice++;
                if (input.Key == ConsoleKey.LeftArrow)
                    choice--;

                if (choice < 0)
                    choice = 2;
                if (choice > 2)
                    choice = 0;

                if (choice == 0 && input.Key == ConsoleKey.Z)
                    Attack();

                
                return;
            }
        }

        public void Remove()
        {
            Console.SetCursorPosition(30, 21);
            Console.Write("　　　");
            Console.SetCursorPosition(50, 21);
            Console.Write("　　　");
            Console.SetCursorPosition(70, 21);
            Console.Write("　　　");
            Console.SetCursorPosition(0, 30);
        }

        public void Attack()
        {
            PotatoState.hp -= 50;
            Render();
            Remove();
            Console.SetCursorPosition(25, 22);
            Console.Write("                                                                     ");
            Console.SetCursorPosition(26, 22);
            Console.Write(" 50 만큼의 데미지를 입혔다!");
            System.Threading.Thread.Sleep(1000);
            Render();
            Console.Write("                                                                     ");
            
            Attacked();
            return;
        }

        public void Attacked()
        {
            PlayerState.hp -= 30;
            
            Console.SetCursorPosition(27, 23);
            Console.Write(" 30 만큼의 데미지를 입었다!");
            System.Threading.Thread.Sleep(1000);
            Render();
            Console.SetCursorPosition(27, 23);
            Console.Write("                                                                     ");
            System.Threading.Thread.Sleep(1000);
            Console.SetCursorPosition(27, 23);
            Console.Write("앗 근데 감자마왕이 기절했다!");
            System.Threading.Thread.Sleep(1000);

            goNextScene = true;
            return;
        }
    }
}

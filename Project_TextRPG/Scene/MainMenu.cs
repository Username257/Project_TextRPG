using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    public class MainMenu : Scene
    {
        Sprites sprites = new Sprites();
        private int choice = 1;
        bool gameStartable = false;
        public MainMenu(Game game) : base(game)
        {
        }

        public override void Render()
        {
            
            sprites.Title();
            sprites.TitleButton();

            Remove();

            if (choice == 1)
            {
                Console.SetCursorPosition(55, 24);
            }
            else if (choice == 2)
            {
                Console.SetCursorPosition(75, 24);
            }
                
            else if (choice == 0)
            {
                Console.SetCursorPosition(35, 24);
            }
                
            else
                Console.WriteLine("choice에 0, 1, 2 이외의 값이 들어감");

            
            Console.Write("▼");

            Console.SetCursorPosition(40, 28);
            Console.WriteLine("방향키로 움직이고 z키를 눌러 선택하세요.");

        }

        public void Remove()
        {
            Console.SetCursorPosition(35, 24);
            Console.Write(' ');
            Console.SetCursorPosition(75, 24);
            Console.Write(' ');
            Console.SetCursorPosition(55, 24);
            Console.Write(' ');
        }

        public override void Update()
        {
            ConsoleKeyInfo input;
            while (true)
            {
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.LeftArrow)
                {
                    choice--;
                    if (choice < 0)
                        choice = 2;
                }
                if (input.Key == ConsoleKey.RightArrow)
                {
                    choice++;
                    if (choice > 2)
                        choice = 0;
                }

                switch (choice)
                {
                    case 0:
                        
                        Render();
                        break;
                    case 1:
                        
                        Render();
                        break;
                    case 2:
                        
                        Render();
                        break;
                    default:
                        Console.WriteLine("뭔가 이상함");
                        break;
                }

                if (choice == 1 && input.Key == ConsoleKey.Z && gameStartable == false)
                {
                    Console.SetCursorPosition(50, 26);
                    Console.WriteLine("\'들어가기에 앞서\'를 먼저 봐 주세요!");
                }
                if (choice == 0 && input.Key == ConsoleKey.Z )
                {
                    Environment.Exit(0);
                }
                if(choice == 2 && input.Key == ConsoleKey.Z )
                {
                    game.BeforeStart();
                    return;
                }

                Console.SetCursorPosition(0, 40);
            }

            


        }
    }
}

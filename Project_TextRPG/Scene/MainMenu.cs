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
     
        public MainMenu(Game game) : base(game)
        {
        }

        public override void Render()
        {
            
            sprites.Title();
            sprites.TitleButton();


            Console.SetCursorPosition(55, 24);

            Console.Write("▼");

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
            Console.SetCursorPosition(55, 24);
            Console.Write("▼");

            while (true)
            {
                Console.SetCursorPosition(0, 30);
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
                        Remove();
                        Console.SetCursorPosition(35, 24);
                        Console.Write("▼");
                        break;
                    case 1:
                        Remove();
                        Console.SetCursorPosition(55, 24);
                        Console.Write("▼");
                        break;
                    case 2:
                        Remove();
                        Console.SetCursorPosition(75, 24);
                        Console.Write("▼");
                        break;
                }

                if (choice == 1 && input.Key == ConsoleKey.Z )
                {
                    Console.SetCursorPosition(50, 26);
                    Console.WriteLine("\'들어가기에 앞서\'를 먼저 봐 주세요!");
                }
                if (choice == 0 && input.Key == ConsoleKey.Z)
                {
                    Environment.Exit(0);
                }
                if (choice == 2 && input.Key == ConsoleKey.Z)
                {
                    game.BeforeStart();
                    return;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    internal class BeforeStart : Scene 
    {
        PrintTextOneByOne PTOBO = new PrintTextOneByOne();
        Sprites sprites = new Sprites();
        string str = "\n ( 사족 ) \n 들어가기에 앞서...\n 본 게임은 윈도우 11 콘솔창, \"돋움체\" 글꼴을 기준으로 만들어졌습니다. \n 이제부터 방향키와 \'z\'키(선택), \'x\'키(간이 메뉴) 만으로 게임이 구성됩니다. \n 콘솔 창 크기를 줄이거나 늘리지 마세요.\n 예외사항을 만들지 말아주세요.. 미완성입니다\n\n\n [ 게임을 시작하기 위해 z를 눌러주세요. ]";

        public BeforeStart(Game game) : base(game)
        {
        }
        public override void Render()
        {
            sprites.Clear();
            Console.SetCursorPosition(0, 10);

        }

        public override void Update()
        {
            PTOBO.print(str, 50);
            
            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Z)
                {
                    game.Naming();
                    return;
                }
            }
            
        }
    }
}

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
        string str = " 들어가기에 앞서...\n 본 게임은 윈도우 11 콘솔창, \"돋움체\" 글꼴을 기준으로 만들어졌습니다. \n 이제부터 방향키와 \'z\'키, \'x\'키 만으로 게임이 구성됩니다. \n\n\n [ 게임을 시작하기 위해 z를 눌러주세요. ]";

        public BeforeStart(Game game) : base(game)
        {
        }
        public override void Render()
        {
            Console.Clear();
            
        }

        public override void Update()
        {
            PTOBO.print(str, 50);
            while (true)
            {

            }
        }
    }
}

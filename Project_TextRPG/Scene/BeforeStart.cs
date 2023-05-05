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
        string str = "들어가기에 앞서...\n본 게임은 윈도우 11 콘솔창, \"돋움체\" 글꼴을 기준으로 만들어졌습니다. \n";

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

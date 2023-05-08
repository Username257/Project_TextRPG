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
        public PotatoBattle(Game game) : base(game)
        {
        }
        public override void Render()
        {
            sprites.Remove();
            sprites.Crown();
            sprites.Potato();
            Console.SetCursorPosition(25, 22);
            Console.WriteLine("【 전투 】           【 아이템 】         【 도망가기 】");
        }

        public override void Update()
        {
            Console.ReadKey();
        }
    }
}

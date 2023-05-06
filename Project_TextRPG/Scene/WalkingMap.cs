using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    internal class WalkingMap : Scene
    {
        public WalkingMap(Game game) : base(game)
        {
        }
        public override void Render()
        {
            
        }

        public override void Update()
        {
            ConsoleKeyInfo input;
            while (true)
            {
                input = Console.ReadKey();
                if (input.Key == ConsoleKey.LeftArrow)
                {

                }
                if (input.Key == ConsoleKey.RightArrow)
                {

                }

            }
        }
    }
}

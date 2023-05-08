using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    internal class Field : Scene
    {
        Sprites sprites = new Sprites();
        int curWalkSprite = 1;
        public int x = 3;
        public bool slimeMove = false;
        bool goNextScene = false;
        public Field(Game game) : base(game)
        {
        }
        public override void Render()
        {
            if (x > 25)
                goNextScene = true;

            sprites.Remove();
            SlimeMove();


            //값에 맞는 걷는 이미지 출력
            if (curWalkSprite == 1) 
            {

                sprites.Walk2(x, 2); 
                System.Threading.Thread.Sleep(100);


            }
            if (curWalkSprite == 2)
            {

                sprites.Walk1(x, 2);
                System.Threading.Thread.Sleep(100);


            }
            if (curWalkSprite == 3) 
            {

                sprites.Walk2(x, 2); 
                System.Threading.Thread.Sleep(100);
                

            }
            if (curWalkSprite == 4) 
            {

                sprites.Walk3(x, 2); 
                System.Threading.Thread.Sleep(100);
            }

            

        }

        public override void Update()
        {
            if (goNextScene)
            {
                game.PotatoSaying();
                return;
            }

            SlimeMove();
            ConsoleKeyInfo input;

            while (Console.KeyAvailable)
                Console.ReadKey(false);

            input = Console.ReadKey();

            

            while (input.Key == ConsoleKey.LeftArrow || input.Key == ConsoleKey.RightArrow)
            {

                if (input.Key == ConsoleKey.LeftArrow)
                {
                    if (x > 0)
                        x--;
                    if (curWalkSprite == 4)
                        curWalkSprite = 1;
                    else
                        curWalkSprite++;
                }
                if (input.Key == ConsoleKey.RightArrow)
                {
                    x++;
                    if (curWalkSprite == 4)
                        curWalkSprite = 1;
                    else
                        curWalkSprite++;
                }
                

                break;
            }
            


        }

        public void SlimeMove()
        {
            string time = game.watch.Elapsed.ToString();
            int timeToInt = int.Parse(time.Substring(6, 2));

            if (timeToInt % 2 == 0)
            {
                if (slimeMove == true)
                    slimeMove = false;
                else
                    slimeMove = true;
            }
            else
            {

            }            

            if (slimeMove == true)
            {
                sprites.Slime(30, 2);
            }
            else
            {
                sprites.SlimeJump(30, 1);
            }

            
        }
    }
}

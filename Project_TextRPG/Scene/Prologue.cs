using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    internal class Prologue
    {
        PrintTextOneByOne PTOBO = new PrintTextOneByOne();
        string str1 = "당신은 이 세계의 『용사』 . . .";
        string str2 = "(대충 마왕을 쓰러뜨리라는 내용)";
        PlayerState playerState = new PlayerState();
        
        public void play()
        {
            PTOBO.print(str1, 100);
            PTOBO.print(str2, 100);
            Console.WriteLine("");
            Console.WriteLine("당신의 이름은?");
            playerState.name = Console.ReadLine();
        }
    }
}

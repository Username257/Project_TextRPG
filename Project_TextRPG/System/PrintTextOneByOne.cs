using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    public struct PrintTextOneByOne
    {
        public string str = "";

        public PrintTextOneByOne(string str)
        {
            this.str = str;
        }
        public void print(string str, int time)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
                System.Threading.Thread.Sleep(time);
            }
            Console.WriteLine("");
        }
        
    }
}

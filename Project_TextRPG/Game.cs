﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TextRPG
{
    public class Game
    {
        private bool isRunning = true;
        private Scene scene;
        private MainMenu mainMenu;
        private BeforeStart beforeStart;

        public void Run()
        {
            Init();
            while (isRunning)
            {
                Render();
                Update();
                
            }
            Release();
        }

        private void Init()
        {
            System.Console.Title = "Hero Of Isekai";
            System.Console.WindowHeight = 600; System.Console.WindowWidth = 600;
            Console.CursorVisible = false;

  
            mainMenu = new MainMenu(this);
            beforeStart = new BeforeStart(this);
            scene = mainMenu;
        }
        private void Render()
        {
            Console.Clear();
            scene.Render();
            
        }
        private void Update()
        {
            scene.Update();
        }
        public void Release()
        {

        }

        public void MainMenu()
        {
            scene = mainMenu;
        }
        public void BeforeStart()
        {
            scene = beforeStart;
        }
    }
}

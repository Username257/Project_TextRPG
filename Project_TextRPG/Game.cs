﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private PotatoSaying potatoSaying;
        private Naming naming;
        private SayMyName sayMyName;
        private Field field;
        private PotatoBattle potatoBattle;
        private Win win;
       
        Sprites sprites = new Sprites();
        public Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();

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
            potatoSaying = new PotatoSaying(this);
            naming = new Naming(this);
            sayMyName = new SayMyName(this);
            field = new Field(this);
            potatoBattle = new PotatoBattle(this);
            win = new Win(this);
            

            scene = mainMenu;
        }
        private void Render()
        {
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
        public void PotatoSaying()
        {
            scene = potatoSaying;
        }
        public void Naming()
        {
            scene = naming;
        }
        public void SayMyName()
        {
            scene = sayMyName;
        }
        public void Field()
        {
            scene = field;
        }
        public void PotatoBattle()
        {
            scene = potatoBattle;
        }
        public void Win()
        {
            scene = win;
        }

       
    }
}

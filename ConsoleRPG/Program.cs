using System;
using System.Collections.Generic;

namespace ConsoleRPG
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "ConsoleRPG";
            var ui = new UIConsole();
            //list base entiti второй лист хранит base block все объекты классов не имеют внутренние названия для програмиста
            ui.PrintLogo();
            while (true)
            {
                
                ui.PrintMenu();
                switch (ui.CurrentCom)
                {
                    case "/play":
                        StartGame();
                        break;

                    case "/about":
                        UIConsole.AboutProg();
                        break;

                    case "/quit":
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void StartGame()
        {
            // Мб сделать отдельную функцию settings чтобы удобно управлять настройками player (и не только) и в будующем их маштабировать?
            int[] pos = { 0, 0 };
            var player = new Player(pos, "&", "player", 100, 10);
            var map = new Map(player);
            while (true)
            {
                map.PrintMap();
                UIConsole.PlayerInfo(player);
                player.Move(Console.ReadKey());
                map.MoveEntety(player);

            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ConsoleRPG
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

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
                        break;
                    case "/quit":
                        break;
                }
            }
        }
        static void StartGame()
        {
            int[] pos = { 0, 0 };
            var player = new Player(pos, "&");
            var map = new Map(player);
            while (true)
            {
                map.PrintMap();
                player.Move(Console.ReadKey());
                map.MoveEntety(player);
            }
        }
    }
}

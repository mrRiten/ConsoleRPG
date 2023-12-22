using System;

namespace ConsoleRPG
{
    internal class Program
    {

        static void Main(string[] args)
        {

            var ui = new UIConsole();
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

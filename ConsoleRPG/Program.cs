using System;

namespace ConsoleRPG
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "ConsoleRPG";
            var ui = new UIConsole();
            bool IsContinue = false;
            ui.PrintLogo();
            while (true)
            {
                ui.PrintMenu();
                switch (ui.CurrentCom)
                {
                    case "/continue":
                        IsContinue = true;
                        StartGame(IsContinue);
                        break;

                    case "/play":
                        StartGame(IsContinue);
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


        static void StartGame(bool IsContinue)
        {
            int[] pos = { 5, 2 };
            var player = new Player(pos, "&", "player", 100, 10);
            var map = new Map(player);
            map.Pursing();

            while (player.IsAlive)
            {
                map.PrintMap(IsContinue);
                UIConsole.PlayerInfo(player);
                player.Move(Console.ReadKey());

                map.MoveEntety(player);
                map.EmemiDamageRangeCheck(player);
                player.CkeckHealth();

                if (IsContinue)
                {
                    IsContinue = false;
                }
            }
        }
    }
}

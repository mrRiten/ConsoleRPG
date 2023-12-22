using System;

namespace ConsoleRPG
{
    internal class UIConsole
    {
        public string CurrentCom { get; set; }
        public void PrintLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("   _____                                 _          _____    _____     _____ \r\n  / ____|                               | |        |  __ \\  |  __ \\   / ____|\r\n | |        ___    _ __    ___    ___   | |   ___  | |__) | | |__) | | |  __ \r\n | |       / _ \\  | '_ \\  / __|  / _ \\  | |  / _ \\ |  _  /  |  ___/  | | |_ |\r\n | |____  | (_) | | | | | \\__ \\ | (_) | | | |  __/ | | \\ \\  | |      | |__| |\r\n  \\_____|  \\___/  |_| |_| |___/  \\___/  |_|  \\___| |_|  \\_\\ |_|       \\_____|\r\n                                                                             \r\n                                                                             ");
        }

        public void PrintMenu()
        {
            PrintCom();
            UserCom();
        }

        private void PrintCom()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Список команд:\n /play - начать игру \n /about - описание игры \n /quit - выйти из игры \n\n ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void UserCom()
        {
            Console.WriteLine("Введите команду\n");
            string _com = Console.ReadLine();
            CurrentCom = _com;
        }
    }
}

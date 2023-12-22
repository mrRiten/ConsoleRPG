using System;

namespace ConsoleRPG
{
    internal class UIConsole
    {
        public string CurrentCom { get; set; }
        public void PrintMenu()
        {
            PrintCom();
            UserCom();
        }
        public void PrintLogo()
        {
            // Сделал логотип по центру
            string text1 = "   _____                                 _          _____    _____     _____ \r\n";
            string text2 = "  / ____|                               | |        |  __ \\  |  __ \\   / ____|\r\n";
            string text3 = " | |        ___    _ __    ___    ___   | |   ___  | |__) | | |__) | | |  __ \r\n";
            string text4 = " | |       / _ \\  | '_ \\  / __|  / _ \\  | |  / _ \\ |  _  /  |  ___/  | | |_ |\r\n";
            string text5 = " | |____  | (_) | | | | | \\__ \\ | (_) | | | |  __/ | | \\ \\  | |      | |__| |\r\n";
            string text6 = "  \\_____|  \\___/  |_| |_| |___/  \\___/  |_|  \\___| |_|  \\_\\ |_|       \\_____|\r\n\n";

            string[] Logo = { text1, text2, text3, text4, text5, text6 };
            int width = Console.WindowWidth;
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < Logo.Length; i++) 
            {
                int centerX = (width - Logo[i].Length) / 2;
                Console.SetCursorPosition(centerX, Console.CursorTop);
                Console.Write(Logo[i]);
            }
        }
        private void PrintCom()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("    Список команд:\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" /play");
            Console.ResetColor();
            Console.Write(" - начать игру\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" /about");
            Console.ResetColor();
            Console.Write(" - описание игры\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" /quit");
            Console.ResetColor();
            Console.WriteLine(" - выйти из игры \n\n");
        }
        private void UserCom()
        {
            Console.Write("Введите команду:\n");
            string _com = Console.ReadLine();
            CurrentCom = _com;
        }
        public static void AboutProg()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nConsoleRPG");
            Console.ResetColor();
            Console.WriteLine(" - захватывающее приключение в мире фэнтези, где игрок взбирается на вершины гор, погружается в глубины подземелий и исследует загадочные леса.");
            Console.WriteLine("Созданная на языке C#, эта консольная игра позволяет игроку выбирать свой путь и сражаться с монстрами.");
            Console.WriteLine("Проходите через эпические квесты, развивайте персонажа, выбирайте свою судьбу и влияйте на окружающий мир.");
            Console.WriteLine("ConsoleRPG предлагает богатую и захватывающую историю, полную тайн и опасностей, ожидающих героя на каждом шагу.");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Авторы: ");
            Console.ResetColor();
            Console.WriteLine("Виталий, Никита и Илья");
            Console.WriteLine("ConsoleRPG распространяется под открытой лицензией.");
        }
        public static void PlayerInfo(BaseEntety player)
        {

            Console.Write("У вас ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(player.Health);
            Console.ResetColor();
            Console.WriteLine(" здоровья");

            Console.Write("У вас ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(player.Damage);
            Console.ResetColor();
            Console.WriteLine(" урона");

            // Console.Write($"У вас {player.Damage} урона");
        }
    }
    
}

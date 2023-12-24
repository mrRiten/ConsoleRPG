using System;
using System.IO;

namespace ConsoleRPG
{
    internal class Save
    {
        static public void SaveMap(string[][] map)
        {
            string path = Config.PathSaveLoad();
            SaveArrayToFile(map, path);
        }

        static private void SaveArrayToFile(string[][] array, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string[] row in array)
                    {
                        foreach (string element in row)
                        {
                            writer.Write(element);
                        }
                        writer.WriteLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении карты игры в файл: {ex.Message}");
            }
        }
    }

    internal class Load
    { 
        static public string[][] LoadMap()
        {
            string path = Config.PathSaveLoad();

            string[] lines = File.ReadAllLines(path);

            string[][] mapLoaded = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                mapLoaded[i] = new string[lines[i].Length];
                
                for (int j = 0; j < lines[i].Length; j++) 
                {
                    mapLoaded[i][j] = lines[i][j].ToString(); 
                }
            }
            return mapLoaded;
        }
    }
}

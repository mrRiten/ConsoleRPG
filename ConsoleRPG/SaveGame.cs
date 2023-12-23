using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleRPG
{
    internal class SaveGame
    {
        static public void SaveMap(string[][] map) 
        {
            string directory = @"..\..\saves\";
            string filename = "SaveMap.txt";
            string path = directory + filename;

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
                Console.WriteLine($"Ошибка при сохранении массива в файл: {ex.Message}");
            }
        }
    }
}

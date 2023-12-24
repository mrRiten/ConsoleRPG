namespace ConsoleRPG
{
    internal class Config
    {
        static public string PathSaveLoad()
        {
            string directory = @"..\..\saves\";
            string filename = "SaveMap.txt";
            string path = directory + filename;
            return path;
        }
    }
}

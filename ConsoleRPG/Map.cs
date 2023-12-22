using System;
using System.Collections.Generic;

namespace ConsoleRPG
{
    internal class Map
    {
        // . - empty field
        // # - wall
        // @ - enemy
        // & - player
        private string[][] DataMap =
            {
                new string[] {".",".",".",".",".",".",".",".","#","."},
                new string[] {"#","#","#",".",".",".",".",".",".","."},
                new string[] {".",".",".",".","#",".","@",".",".","."},
                new string[] {".",".",".",".",".",".","@",".",".","."},
                new string[] {".",".","#",".",".",".",".",".",".","#"},
                new string[] {"#",".",".",".",".",".",".",".",".","."},
                new string[] {".",".","#",".",".",".",".",".","#","."},
                new string[] {".",".",".",".",".",".",".",".",".","."},
                new string[] {".",".",".","#",".","#",".",".",".","."},
                new string[] {".",".",".",".",".",".",".",".",".","."},
            };

        public Map(BaseEntety entetie)
        {
            MoveEntety(entetie);
        }

        public Map(List<BaseEntety> enteties)
        {
            foreach (var ent in enteties)
            {
                MoveEntety(ent);
            }
        }

        public bool DetectBlock(BaseEntety entety)
        {
            if (DataMap[entety.PositionY][entety.PositionX] == "#")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void PrintMap()
        {
            Console.Clear();
            // Drawing the map
            foreach (var line in DataMap)
            {
                foreach (var item in line)
                {
                    Console.Write($" {item} ");
                }
                Console.WriteLine("");
            }
        }

        public bool ValidationPosition(int posX, int posY)
        {
            if ((posX >= 0 && posX < 10) && (posY >= 0 && posY < 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MoveEntety(BaseEntety baseEntety)
        {
            if (ValidationPosition(baseEntety.PositionX, baseEntety.PositionY) && DetectBlock(baseEntety))
            {
                DataMap[baseEntety.OldPos[1]][baseEntety.OldPos[0]] = ".";
                DataMap[baseEntety.PositionY][baseEntety.PositionX] = baseEntety.Designation;
            }
            else
            {
                baseEntety.PositionX = baseEntety.OldPos[0];
                baseEntety.PositionY = baseEntety.OldPos[1];
            }
        }

    }
}

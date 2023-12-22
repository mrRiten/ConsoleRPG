using System;

namespace ConsoleRPG
{
    abstract class BaseEntety
    {
        public abstract string Name { get; set; }
        public abstract int PositionX { get; set; }
        public abstract int PositionY { get; set; }
        public abstract string Designation { get; set; }
        public abstract int Health { get; set; }
        public abstract int Damage { get; set; }

        public abstract int[] OldPos { get; set; }

        public BaseEntety(int[] pos, string desing)
        {
            PositionX = pos[0];
            PositionY = pos[1];
            Designation = desing;
            OldPos = new int[] { PositionX, PositionY };
        }

    }

    internal class Player : BaseEntety
    {
        public override string Name { get; set; }
        public override int PositionX { get; set; }
        public override int PositionY { get; set; }
        public override string Designation { get; set; }
        public override int Health { get; set; }
        public override int Damage { get; set; }

        public override int[] OldPos { get; set; }

        public Player(int[] pos, string desing) : base(pos, desing)
        {

        }

        public Player(int[] pos, string desing, string name, int health, int damage) : base(pos, desing)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void Move(ConsoleKeyInfo userKey)
        {
            OldPos[0] = PositionX;
            OldPos[1] = PositionY;

            switch (userKey.Key)
            {
                case ConsoleKey.W:
                    PositionY--;
                    break;

                case ConsoleKey.S:
                    PositionY++;
                    break;

                case ConsoleKey.D:
                    PositionX++;
                    break;

                case ConsoleKey.A:
                    PositionX--;
                    break;

            }
        }

    }
}

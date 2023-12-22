namespace ConsoleRPG
{
    abstract class BaseBlock
    {
        public abstract int PositionX { get; set; }
        public abstract int PositionY { get; set; }
        public abstract string Designation { get; set; }
        public abstract int Health { get; set; }
        public BaseBlock(int[] pos, string dising, int health)
        {
            PositionX = pos[0];
            PositionY = pos[0];
            Designation = dising;
            Health = health;
        }
    }

    internal class Wall : BaseBlock
    {
        public override int PositionX { get; set; }
        public override int PositionY { get; set; }
        public override int Health { get; set; }
        public override string Designation { get; set; }
        public Wall(int[] pos, string dising, int health) : base(pos, dising, health)
        {

        }
    }
}

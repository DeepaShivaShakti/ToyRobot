namespace ToyRobot
{
    public enum Facing
    {
        North,
        East,
        South,
        West
    }

    public class Robot
    {
        private int x;
        private int y;
        private Facing f;
        private const int tableSize = 5;

        public void Place(int x, int y, Facing f)
        {
            if (IsValidPosition(x, y))
            {
                this.x = x;
                this.y = y;
                this.f = f;
            }
            else
            {
                Console.WriteLine("Placing ignored as position not valid");
            }
        }

        public void Move()
        {
            int moveToX = x;
            int moveToY = y;
            if (f == Facing.North)
            {
                moveToY++;
            }
            if (f == Facing.South)
            {
                moveToY--;
            }
            if (f == Facing.West)
            {
                moveToX--;
            }
            if (f == Facing.East)
            {
                moveToX++;
            }
            if (IsValidPosition(moveToX, moveToY))
            {
                x = moveToX;
                y = moveToY;
            }
            else
            {
                Console.WriteLine("Move ignored to prevent falling from table.");
            }
        }

        public void Left()
        {
            f = (Facing)(((int)f + 3) % 4);
        }

        public void Right()
        {
            f = (Facing)(((int)f + 1) % 4);
        }

        public string Report()
        {
            var status = String.Format("Robot is at ({0},{1}) facing {2}", x, y, f);
            Console.WriteLine(status);
            return status;
        }

        private bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < tableSize && y >= 0 && y < tableSize;
        }
    }
}

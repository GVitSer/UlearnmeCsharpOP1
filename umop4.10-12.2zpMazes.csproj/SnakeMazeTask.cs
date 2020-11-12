namespace Mazes
{
    public static class SnakeMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int right = width - 3, down = 2;
            while (robot.Finished == false)
            {
                MoveRight(robot, right);
                MoveDown(robot, down);
                MoveLeft(robot, right);
                if (robot.Finished == false)
                { MoveDown(robot, down); }
            }
        }
        public static void MoveRight (Robot robot, int a)
        {
            for (int i = 0; i < a; i++)
            { robot.MoveTo(Direction.Right); }
        }
        public static void MoveLeft(Robot robot, int a)
        {
            for (int i = 0; i < a; i++)
            { robot.MoveTo(Direction.Left); }
        }
        public static void MoveDown (Robot robot, int a)
        {
            for (int i = 0; i < a; i++)
            { robot.MoveTo(Direction.Down); }
        }
    }
}
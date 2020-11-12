namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int wh, hw;
            wh = (width - 2) / (height - 2);
            hw = (height - 2) / (width - 2);
            while (robot.Finished == false)
            {
                if (width > height)
                { Move(robot, wh, Direction.Right, Direction.Down); }
                else
                { Move(robot, hw, Direction.Down, Direction.Right); }
            }
        }
        public static void Move(Robot robot, int aspectRatio, Direction direction, Direction directionTwo)
        {
            if (!robot.Finished) 
                for (var i = 0; i < aspectRatio; i++) 
                    robot.MoveTo(direction);
            if (!robot.Finished) 
                robot.MoveTo(directionTwo);
        }
    }
}
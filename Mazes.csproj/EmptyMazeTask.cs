using System;

namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void Move(Robot robot, int distance, Direction dir, int coordinate)
		{
			if (coordinate != (distance - 2))
				robot.MoveTo(dir);
		}

		public static void MoveRobot(Robot robot, int width, int height)
		{
			Move(robot, height, Direction.Down, robot.Y);
			Move(robot, width, Direction.Right, robot.X);
		}

		public static void MoveOut(Robot robot, int width, int height)
		{
			while (robot.X != (width - 2) || robot.Y != (height - 2))
				MoveRobot(robot, width, height);
		}
	}
}
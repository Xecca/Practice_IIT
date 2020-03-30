//using System;

namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveInDirection(Robot robot, int distance, Direction direction)
		{
			for (int i = 1; i < distance - 2; i++)
			{
				if (direction == Direction.Left)
					robot.MoveTo(Direction.Left);
				else if (direction == Direction.Right)
					robot.MoveTo(Direction.Right);
				else
					robot.MoveTo(Direction.Down);
			}
		}

		public static void MoveLikeSnake(Robot robot, int width, int height, int countMoveDown)
		{
			for (int i = 0; i < countMoveDown; i++)
			{
				MoveInDirection(robot, width, Direction.Right);
				MoveInDirection(robot, 5, Direction.Down);
				MoveInDirection(robot, width, Direction.Left);
				if (robot.Y == height - 2 && robot.X == 1 && height > width)
					break;
				if (robot.Y < height - 2 && robot.X < width - 2)
					MoveInDirection(robot, 5, Direction.Down);
			}
		}

		public static void MoveOut(Robot robot, int width, int height)
		{
			int countMoveDown = (height - 3) / 3;
			if (height <= 5)
				countMoveDown = 1;
			MoveLikeSnake(robot, width, height, countMoveDown);
		}
	}
}
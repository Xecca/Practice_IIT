namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveInDirection(Robot robot, int countMove, Direction direction)
		{
			for (int i = 0; i < countMove; i++)
			{
				if (direction == Direction.Right)
					robot.MoveTo(Direction.Right);
				else
					robot.MoveTo(Direction.Down);
			}
		}

		public static Direction SelectionSecondDirection(Direction firstDirection)
		{
			Direction secondDirection = Direction.Right;

			if (firstDirection == Direction.Right)
				secondDirection = Direction.Down;

			return secondDirection;
		}

		public static void MoveAlongTheDiagonal(Robot robot, int width, int height,
			int countLongMove, Direction firstDirection)
		{
			Direction secondDirection = SelectionSecondDirection(firstDirection);

			for (int i = 0; i < height - 2; i++)
			{
				MoveInDirection(robot, countLongMove, firstDirection);
				if (robot.X == width - 2 && robot.Y == height - 2)
					break;
				MoveInDirection(robot, 1, secondDirection);
			}
		}

		public static void MoveOut(Robot robot, int width, int height)
		{
			int countLongMove = (height - 2) / (width - 2);
			Direction firstDirection = Direction.Down;

			if (width > height)
			{
				countLongMove = (width - 2) / (height - 2);
				firstDirection = Direction.Right;
			}
			MoveAlongTheDiagonal(robot, width, height, countLongMove, firstDirection);
		}
	}
}
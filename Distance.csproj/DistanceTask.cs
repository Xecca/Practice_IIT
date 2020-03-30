using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
			double distance = 0;

			distance = Math.Abs((by - ay) * x - (bx - ax) * y + bx * ay - by * ax) / Math.Sqrt(Math.Pow((by - ay), 2) + Math.Pow((bx - ax), 2));
			return distance;
		}
	}
}
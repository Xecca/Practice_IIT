// В этом пространстве имен содержатся средства для работы с изображениями. 
// Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System;
using System.Drawing;

namespace Fractals
{
	internal static class DragonFractalTask
	{
        public static double[]  ChangeCoordinateOnAngle(double[] coordinate, int randomNumber, double angleDegree)
        {
			double              angle = angleDegree * Math.PI / 180;
            double calcCoordinate = (coordinate[0] * Math.Cos(angle) - coordinate[1] * Math.Sin(angle)) / Math.Sqrt(2);

            coordinate[2] = calcCoordinate;
			if (randomNumber != 0)
				coordinate[2] += 1;
			coordinate[3] = (coordinate[0] * Math.Sin(angle) + coordinate[1] * Math.Cos(angle)) / Math.Sqrt(2);

			return coordinate;
        }

		public static double[]  ChangeCoordinate(double[] coordinate, int randomNumber)
		{
			//double x0, y0 = 0.0;
			double              angleDegree = 45.0;

			if (randomNumber != 0)
				angleDegree = 135;
			coordinate = ChangeCoordinateOnAngle(coordinate, randomNumber, angleDegree);
			//x = x0;
			coordinate[0] = coordinate[2];
			//y = y0;
			coordinate[1] = coordinate[3];

			return coordinate;
		}

		public static void      DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
			int randomNumber = 0;
            //double x = 1.0;
            //double y = 0.0;
			double[] coordinate = new double[] { 1.0, 0.0, 0.0, 0.0 }; // 0 - x, 1 - y, 2 - x0, 3 - y0

		    // 1. Создание нового генератора последовательности случайных чисел:
		    Random random = new Random(seed);
			
			pixels.SetPixel(coordinate[0], coordinate[1]);
			for (int i = 0; i < iterationsCount; i++)
			{
			    // seed — число полностью определяющее все последовательность псевдослучайных чисел этого генератора.
			    // 2. Получение очередного псевдослучайного числа от 0 до 2:
			    randomNumber = random.Next(2);
				coordinate = ChangeCoordinate(coordinate, randomNumber);
				pixels.SetPixel(coordinate[2], coordinate[3]);
			}
		}
	}
}
			/*
			Начните с точки (1, 0)
			Создайте генератор рандомных чисел с сидом seed
			
			На каждой итерации:

			1. Выберите случайно одно из следующих преобразований и примените его к текущей точке:

				Преобразование 1. (поворот на 45° и сжатие в sqrt(2) раз):
				x' = (x · cos(45°) - y · sin(45°)) / sqrt(2)
				y' = (x · sin(45°) + y · cos(45°)) / sqrt(2)

				Преобразование 2. (поворот на 135°, сжатие в sqrt(2) раз, сдвиг по X на единицу):
				x' = (x · cos(135°) - y · sin(135°)) / sqrt(2) + 1
				y' = (x · sin(135°) + y · cos(135°)) / sqrt(2)
		
			2. Нарисуйте текущую точку методом pixels.SetPixel(x, y)

			*/
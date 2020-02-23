using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxAreaLib
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public static class BoxArea
    {
        private static int CalculateArea(string points)
        {
            try
            {
                points = points.Replace("[", "");
                points = points.Replace("]", "");

                points = points.Replace("),", ")|");

                points = points.Replace("(", "");
                points = points.Replace(")", "");

                var auxPoints = points.Split("|");

                List<Point> areaPoints = new List<Point>();

                foreach (var auxPoint in auxPoints)
                {
                    Point pointXY = new Point();

                    pointXY.X = Int16.Parse(auxPoint.Split(",")[0]);
                    pointXY.Y = Int16.Parse(auxPoint.Split(",")[1]);

                    areaPoints.Add(pointXY);
                }

                int large = areaPoints.Max(x => x.X) - areaPoints.Min(x => x.X);
                int high = areaPoints.Max(y => y.Y) - areaPoints.Min(y => y.Y);


                return high * large;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public static void BoxAreaExecute()
        {
            try
            {
                Console.WriteLine("BOX AREA\n************************************************************************************************");
                

                Console.WriteLine("Type the points as the next example:\n[(0,0), (-1,1), (1, -1), (1, 1), (-1, -1)]\n");

                var pointsArea = Console.ReadLine();

                Console.WriteLine("\nThe Area Calculated is:");

                Console.WriteLine(CalculateArea(pointsArea));
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }
            Console.ReadKey();
        }
    }
}

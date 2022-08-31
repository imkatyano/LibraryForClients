namespace ClassLibraryForClientsNet
{
    public static class Calculation
    {
        public static double? AreaOfCircleCalculation(double radius)                             // поиск площади круга по радиусу
        {
            if (radius <= 0) return null;
            else return Math.PI * Math.Pow((double)radius, 2);

        }
        public static double? AreaOfTriangleCalculation(double a, double b, double c)            // поиск площади треугольника по сторонам
        {

            if (a < 0 || b < 0 || c < 0) return null;
            if (a >= (b + c) || b >= (a + c) || c >= (a + b)) return null;

            // проверка на то, является ли треугольник прямоугольным (теорема Пифагора)   
            if ((((a < b) && (b < c)) || ((b < a) && (a < c))) && Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine("The triangle is rectangular");
            }
            else if ((((c < a) && (a < b)) || ((a < c) && (c < b))) && Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
            {
                Console.WriteLine("The triangle is rectangular");
            }
            else if ((((c < b) && (b < a)) || ((b < c) && (c < a))) && (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)))
            {
                Console.WriteLine("The triangle is rectangular");
            }
            else
            {
                Console.WriteLine("The triangle is not rectangular");
            }

            // поиск площади треугольника

            double semiperimeter = (a + b + c) / 2; //полупериметр суммы сторон
            return Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
        }
    }
}
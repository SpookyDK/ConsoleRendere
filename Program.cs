using System; 

namespace ConsoleRendere

{

   internal class Program

   {

      static void Main(string[] args)

      {
        Console.CursorVisible = false;
            Console.Clear();
            Point punkt1 = new Point(100, 9);
            Point punkt2 = new Point(1, 1);
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            Console.WriteLine(height + " " + width );
            Console.WriteLine(punkt1.x + " " + punkt1.y);
            DrawLine(punkt1, punkt2);
            


      }

      static void DrawLine(Point point1, Point point2)
      {
            float Angle = (float)(point2.y - point1.y) / (float)(point2.x - point1.x);
            Console.WriteLine(Angle);
            if (point2.x < point1.x)
            {
                for (int i = point2.x; i < point1.x; i++)
                {
                    Console.SetCursorPosition(i, (int)(i * Angle));
                    Console.Write("*");
                }
            }
            if (point1.x < point2.x )
            {
                for (int i = point1.x; i < point2.x; i++)
                {
                    Console.SetCursorPosition(i, (int)(i * Angle));
                    Console.Write("*");
                }

            }
            
      }

   }

   class Point
   {
        public int x;
        public int y;
        public Point(int r, int c)
        {
            x = r;
            y = c;
        }
   }

}
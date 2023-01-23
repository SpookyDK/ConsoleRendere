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
            Point punkt2 = new Point(1, 7);
            Point punkt3 = new Point(1, 30);
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;
            Console.WriteLine(height + " " + width );
            
            //DrawLine(punkt1, punkt2);
            DrawTriangle(punkt1, punkt2, punkt3);
            


      }

      static void DrawLine(Point point1, Point point2)
      {
            float Angle = (float)(point2.y - point1.y) / (float)(point2.x - point1.x);
            int offset = (int)(point2.y - Angle * point2.x);
            
            if (point2.x < point1.x)
            {
                for (int i = point2.x; i < point1.x; i++)
                {
                    Console.SetCursorPosition(i, (int)(i * Angle) + offset);
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
             if (point1.x == point2.x)
            {
                
                for (int i = point1.y; i < point2.y; i++)
                {
                    Console.SetCursorPosition(point1.x, i );
                    Console.Write("*");
                }
                for (int i = point2.y; i < point1.y; i++)
                {
                    Console.SetCursorPosition(point1.x, i );
                    Console.Write("*");
                }

            }
            
      }
      static void DrawTriangle(Point point1, Point point2, Point point3)
      {
        DrawLine(point1, point2);
        DrawLine(point1, point3);
        DrawLine(point3, point2);
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
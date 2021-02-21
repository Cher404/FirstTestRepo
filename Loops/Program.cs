using System;

namespace LoopColumsRows
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter colums count");
            int columsCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter rows count");
            int rowsCount = int.Parse(Console.ReadLine());
            int w = 0;
            while (w < rowsCount)
            {
                int x = 0;
                while (x < columsCount)
                {
                    Console.Write("*");
                    x = x + 1;
                }
                w = w + 1;

                Console.WriteLine();*/


            // бочинка ромба

            /*Console.WriteLine("Enter rows count");
             int rowsCount = int.Parse(Console.ReadLine());
              int w = 0;
              while (w < rowsCount)
              {
                  int x = rowsCount - w;
                  while (x <= rowsCount)
                  {
                      Console.Write("*");
                      x++;
                  }
                  w++;

                Console.WriteLine();

              }
            w--;            
            while (w > 0) 
            {
                int u = w;
                while (u > 0)
                {                
                    Console.Write("*");
                    u--;
                }
                w--;
                Console.WriteLine();
            }*/


            //  перевернутий трикутник

            /*Console.WriteLine("Enter number");
            int EntNumb = int.Parse(Console.ReadLine());
            int spaces = EntNumb - 1;
            int stars = EntNumb - spaces;
            int a = 0;
            while ( a < EntNumb )
            {
                int count = 0;
                while (count < spaces )
                {
                    Console.Write(" ");
                    count++;
                }
                

                int n = 0;
                while ( n < stars )
                {
                   Console.Write("*");
                    n++;
                }                
                spaces--;
                stars++;
                a++;
                Console.WriteLine();
            }*/
           
            Console.WriteLine("Enter number");
            int EntNumb = int.Parse(Console.ReadLine());
            int spaces = EntNumb - 1;
            int stars = EntNumb - spaces;
            int a = 0;
            int duble = EntNumb / 2;
            while (a < EntNumb)
            {
                int count = 0;
                while (count < spaces)
                {
                    Console.Write(" ");
                    count++;
                }
                int n = 0;
                while (n < stars)
                {
                    Console.Write("*");
                    n++;
                }
                spaces--;
                stars = stars + 2;
                a++; 
                Console.WriteLine();
            }
            
            spaces+=2;
            stars = stars - 4;
            int y = EntNumb - 1;
            while (y > 0)
            {
                int p = 0;
                while (spaces > p)
                {
                    Console.Write(" ");
                    p++;

                }
                int k = stars;
                while (k > 0)
                {
                    Console.Write("*");
                    k--;
                }
                y--;
                spaces++;
                stars = stars - 2;
                Console.WriteLine();
            }




        }


     }


 }


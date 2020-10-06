﻿using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Week_2__Loops_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            // LINE
            for (int i = 0; i < n ; i++)
            {
            Console.Write("#");
            }

            Console.WriteLine("\n\n");


            // SQUARE
            for (int i = 0; i < n; i++)
            {
            
            for (int j = 0; j < n; j++)
            {
            Console.Write("#");
            }
            Console.WriteLine();
            }
          
            Console.WriteLine("\n\n");


            // RIGHT TRIANGLE
            for (int i = 0; i < n; i++)
            {
            
            for (int j = -1; j < i; j++)
            {
            Console.Write("#");
            }
            Console.WriteLine();
            }

            Console.WriteLine("\n\n");


            // PARALLELOGRAM
            for (int i = 0; i < n; i++)
            {
            for (int j = n; j > i+1; j--)
            {
            Console.Write(" ");
            
            }
            for (int index = 0; index < n; index++)
            {
            Console.Write("#");
            }
            Console.WriteLine();
            }
            Console.WriteLine("\n\n");


            // ISOSCELES TRIANGLE
            for (int i = 0; i < n; i++)
            {

            for (int j = i; j+1 < n; j++)
            {
            Console.Write(" "); 
            }

            for (int index = 0; index < i*2+1; index++)
            {
            Console.Write("#");
            }

            Console.WriteLine();
            }
            Console.WriteLine("\n\n");


            // SQUARE BLANK ROW HORIZONTAL
            for (int i = 0; i < n-n/2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                Console.Write("#");   
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");


            // SQUARE BLANK ROW VERTICAL
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-n/2; j++)
                {
                Console.Write("#");
                Console.Write(" ");
                }
            Console.WriteLine(); 
            }
            Console.WriteLine("\n\n");


            // GRID
            for (int j = 0; j < n; j++)
            {
            Console.Write("#");   
            }
            Console.WriteLine(); 
            for (int i = 0; i < n-n/2-1; i++)
            {
                for (int j = 0; j < n-n/2; j++)
                {
                Console.Write("#");
                Console.Write(" ");
                }
                Console.WriteLine();

                for (int j = 0; j < n; j++)
                {
                Console.Write("#");   
                }
            Console.WriteLine(); 
            }
            Console.WriteLine("\n\n");


            // FENCE
            for (int j = 0; j < n-n/2-1; j++)
            {
            Console.Write(" ");
            Console.Write("#"); 
            }
            Console.WriteLine(); 
            for (int i = 0; i < n-n/2-1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                Console.Write("#");
                }
                Console.WriteLine();

                for (int j = 0; j < n-n/2-1; j++)
                {
                Console.Write(" ");
                Console.Write("#"); 
                  
                }
            Console.WriteLine(); 
            }
            Console.WriteLine("\n\n");


            // CHESSBOARD
            for (int j = 0; j < n-n/2; j++)
            {
            Console.Write("#"); 
            Console.Write(" ");
            }
            Console.WriteLine(); 
            for (int i = 0; i < n-n/2-1; i++)
            {
                for (int j = 0; j < n-n/2-1; j++)
                {
                Console.Write(" ");
                Console.Write("#"); 
                  
                }
                Console.WriteLine(); 
                for (int j = 0; j < n-n/2; j++)
                {
                Console.Write("#"); 
                Console.Write(" ");
                }
            Console.WriteLine(); 
            }
            Console.WriteLine("\n\n");


            // BASIC BITCH SLOPE
            n = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                Console.Write("#");
                }
                Console.WriteLine();
                n += n;
                if (n > 80)
                {break;}
            }
            Console.WriteLine("\n\n");


            // REVERSE SLOPE
            n = 5;
            int num = 40;
            for (int i = 0; i < 10; i++)
            {   
                for (int j = num+1; 0 < --j;)
                {
                Console.Write("#");
                }
                Console.WriteLine();
                
                num -= n;
            }

            Console.WriteLine();

            //CLIFF
            n = 5;
            int m = n*n;
            for (int i = 1; i < n*m; i++)
            {
               for (int j = 0; j < i; j++)
               {
                   for (int k = 0; k < n; k++)
                   {
                   Console.Write("#");
                   } 
               Console.WriteLine();
               }
                n--;
            }
            Console.WriteLine("\n\n");


            //ROWS AND ROWS WITH STUFF BUT ROWS GETTING SMALLER AND STUFF TOO
            m = n;
            int o = m;
            for (int i = 1; i < o+1; i++)
            {
            m = n;
               for (int j = 0; j < m; j++)
               {   
                   for (int k = 0; k < n; k++)
                   {
                   Console.Write("#");
                   }
               n -= 1;  
               Console.Write(" ");
               }
               n = m-1;
                Console.WriteLine();
            }
            Console.WriteLine("\n\n");
            Console.Clear();

            // MEASURING TAPE
            Console.Write("Enter your magic number: ");
            string numberText = Console.ReadLine();
            n = Int32.Parse(numberText);
            Console.WriteLine();

            for (int i = 0; i < n*2+1; i++)
            {
            int x = 0 + (5*i);
            if (x < 10)
            {
            Console.Write($"{x}    ");
            }
            
            else
            {
            Console.Write($"{x}   ");
            }

            }
            Console.WriteLine();
            Console.Write("|");
            for (int i = 1; i < n*2+1; i++)
            {
            Console.Write("____|");
            }
            Console.WriteLine("\n\n");
           

            //SAND CASTLE
            if (n > 1)
            {
            for (int i = 0; i < n; i++)
            {
            Console.Write("[^^^] ");
            }
            Console.WriteLine();
            Console.Write(" ");
           
            for (int i = 0; i < n-1; i++)
            {
            Console.Write("| |");

            for (int j = 0; j < 3; j++)
            {
            Console.Write("_");
            }
            }

            Console.Write("| |");
            Console.WriteLine();
            Console.Write(" |");

            for (int j = 0; j < n*3 - 4; j++)
            {
            Console.Write(" ");
            }
            
            Console.Write("/|\\");

            for (int j = 0; j < n*3 -4; j++)
            {
            Console.Write(" ");
            }
            
        
        Console.Write("|");

             Console.WriteLine();

        Console.Write(" |");

            for (int j = 0; j < n*3 -4; j++)
            {
            Console.Write("_");
            }

        Console.Write("|||");

            for (int j = 0; j < n*3 -4; j++)
            {
            Console.Write("_");
            }

        Console.Write("|");

         Console.WriteLine("\n\n");
            }

            else if (n == 1)
            {
            Console.WriteLine("[^^^]");
            Console.WriteLine(" | |");
            Console.WriteLine(" /|\\");
            Console.WriteLine(" |||");
            }


            // DIGIT
            Console.ForegroundColor = ConsoleColor.DarkGray; 
            n = (10 % n);
            Console.WriteLine($"{n}\n");

            if (n == 0)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _ ");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.Write("_");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|");
            Console.Write("|");
            Console.Write("_");
            Console.Write("|");
            }
            
            if (n == 1)
            {
            Console.WriteLine(" _ ");
                    
            Console.Write("|");
                
            Console.Write("_");
                Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("|");
                Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.Write("|");
            Console.Write("_");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|");
            }

            
            if (n == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _ ");
                 Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.Write("|");    
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("_");
            Console.WriteLine("|");
            Console.Write("|");
            Console.Write("_");
                Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.Write("|");
            }

            
            if (n == 3)
            {
                       Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _ ");
            Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("_");
            Console.WriteLine("|");
                Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("_");
            Console.Write("|");
            }
      

            if (n == 4)
            {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" _ ");
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("_");
            Console.WriteLine("|");
                Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.Write("|");
            Console.Write("_");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|");
            }
  
            if (n == 5)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _ ");
            Console.Write("|");
            Console.Write("_");
                Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.WriteLine("|");
            Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("_");
            Console.Write("|");
            }
            
            if (n == 6)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _ ");
            Console.Write("|");
            Console.Write("_");
                Console.ForegroundColor = ConsoleColor.DarkGray; 
            Console.WriteLine("|");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|");
            Console.Write("_");
            Console.Write("|");
            }


            if (n == 7)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _ ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|");
            Console.Write("_");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("|");
                Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|");
            Console.Write("_");
                Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("|");
            }
          

            if (n == 8)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _ ");
            Console.Write("|");
            Console.Write("_");
            Console.WriteLine("|");
            Console.Write("|");
            Console.Write("_");
            Console.Write("|");
            }

            if (n == 9)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" _ ");
            Console.Write("|");
            Console.Write("_");
            Console.WriteLine("|");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("_");
            Console.Write("|");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White; 


        //MURICA FLAG


//      ()__________
//      ||* * *     |
//      || * * #####|
//      ||* * *     |
//      ||##########|
//      ||          |
//      ||##########|
//      || 

        //CABBAGE LAND

//      ()____________
//      ||   | |      |
//      ||   | |      |
//      ||___| |______|
//      ||___   ______|
//      ||   | |      |
//      ||   | |      |
//      ||___|_|______|
//      ||

        // YE OL TEA BAG FLAG

//      ()_____________
//      ||\ \  | |  / /|
//      || \ \ | | / / |
//      ||__\_\| |/_/__|
//      ||_____   _____|
//      ||  / /| |\ \  |
//      || / / | | \ \ |
//      ||/_/__|_|__\_\|
//      ||



        }
    }
}

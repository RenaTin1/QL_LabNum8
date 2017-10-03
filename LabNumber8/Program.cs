using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8
{
    class Program
    {
        static void Main(string[] args)
        {

            int AtBat;

            Console.WriteLine("Welcome to Batting Average Calculator!");
            Console.WriteLine("Enter number of times at bat:");
            AtBat = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(" 0= out, 1= Single, 2 =Double, 3= Triple, 4= Home Run");
            Batting(AtBat);
        }


        public static void Batting(int AtBat)
        {
            int[] BatArray = new int[AtBat];
            for (int i = 0; i <= BatArray.Length - 1; i++)
            {
                Console.WriteLine($"Result for at-bat 0:{i}");
                BatArray[i] = int.Parse(Console.ReadLine());
            }

            double sum = 0;

            for (int i = 0; i <= BatArray.Length - 1; i++)
            {
                sum = sum + BatArray[i]; //Adding all the elements together

            }
          
                 
            double count = 0;
          
           foreach(int Element in BatArray )
                if (Element != 0)
                {
                    count++;
                }

            double BatAvg = count / AtBat;
            Console.WriteLine($"Batting Average:{BatAvg} ");

            double SlugPercent = sum / AtBat;
            Console.WriteLine($"Slugging Percentage: {SlugPercent}");

            Console.WriteLine("Another batter? (y/n)");
        }
    }

}
   

using System;


namespace SortTheNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //todo Set the background, buttons, timer
            //todo pick and sort the numbers ->go to the database, create the randomizer, pick the numers
            //todo compare
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Sort the numbers in ascending order");
            int TopLeft, TopRight, BottomLeft, BottomRight;
            Random randomizer = new Random();
            

            TopLeft = randomizer.Next(1,10);
            TopRight = randomizer.Next(1, 10);
            BottomLeft = randomizer.Next(1, 10);
            BottomRight =  randomizer.Next(1, 10);

            Console.WriteLine($"??? {TopLeft} ??? {TopRight} ???");
            Console.WriteLine($"??? {BottomLeft} ??? {BottomRight} ???");

            //sorting

            int[] sortedArray = new int[] { TopLeft, TopRight, BottomLeft, BottomRight};

            for (int i=sortedArray.Length-1;i>0;i--)
                for (int j=0;j<i;j++)
            {  
                    if(sortedArray[j]>sortedArray[j+1])
                    {
                        int buffer = sortedArray[j];
                        sortedArray[j] = sortedArray[j + 1];
                        sortedArray[j + 1] = buffer;
                    }
            }

            int[] inputArray = new int[4];
            for (int i = 0; i < 4; i++)
            { inputArray[i] = int.Parse(Console.ReadLine()); }

            bool ok = true;

            for(int i=0;i<4;i++)
            {
                if (sortedArray[i] != inputArray[i]) ok = false;
            }

            if (ok) Console.WriteLine("YES!You WON!");
            else Console.WriteLine("Try again!");



        }
    }
}

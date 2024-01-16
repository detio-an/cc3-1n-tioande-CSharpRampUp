using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Weight in Pounds (lbs): ");
        float pounds = float.Parse(Console.ReadLine());
        float kilograms = pounds * 0.45359237f;
        Console.WriteLine($"Weight converted to kilograms (kg): {kilograms}");
        Console.WriteLine("================================================================");

        Console.Write("Distance in Miles (mi): ");
        float miles = float.Parse(Console.ReadLine());
        float kilometers = miles * 1.609344f;
        Console.WriteLine($"Distance converted to kilometers (km): {kilometers}");
        Console.WriteLine("================================================================");

        Console.Write("Temperature in Fahrenheit (°F): ");
        float fahrenheit = float.Parse(Console.ReadLine());
        float celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature converted to Celsius (°C): {celsius}");
        Console.WriteLine("================================================================");

        int[] studentAges = new int[10];
        int summ = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Age of student {i + 1}: ");
            studentAges[i] = int.Parse(Console.ReadLine());
            summ += studentAges[i];
        }

        double ave = (double)summ / 10;
        Console.WriteLine($"The average age of the students is: {ave}");
        Console.WriteLine("================================================================");

        string grumpyTree = "tall grumpy tree";
        string littleGirl = "kind small girl";
        string oldGranny = "grandma";
        string bigWarmScarf = "scarf";
        string hotHeaded = "grumpy";

        Console.WriteLine($"There was once a {grumpyTree}, it was the biggest tree in the forest, and it didn't need its shadow for anything. However, the tree would never share its shadow with any of the animals and wouldn't let them come anywhere near.");

        Console.WriteLine($"One year, the autumn and winter were terrible, and the tree, without its leaves, was going to die of cold. A {littleGirl}, who went to live with her {oldGranny} that winter, found the tree shivering. She went to get a great {bigWarmScarf} to warm the tree up. The Spirit of the Forest appeared and told the little girl why that tree was so {hotHeaded}, and why no one would help him. Even so, the girl decided to put the scarf on the tree.");

        Console.WriteLine($"The next springtime, the tree had learned from the girl's generosity. When she sat next to the trunk, the tree bent down to shade her from the sun. The Spirit of the Forest saw this and went to tell all the animals. He told them that from then on they would be able to shade themselves well, because the tree had learned that having kind and generous beings around makes the world a much better place to live in.");

        Console.WriteLine("================================================================");

        Console.WriteLine();

        int nPattern = 0;
        do
        {
            Console.Write("*Number Pattern* Please input positive number: ");
            nPattern = int.Parse(Console.ReadLine());

            if (nPattern <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        } while (nPattern <= 0);

        Console.WriteLine("Number Pattern:");
        for (int i = 1; i <= nPattern; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        int nSum = 0;
        do
        {
            Console.Write("*Sum of Numbers* Please input positive number: ");
            nSum = int.Parse(Console.ReadLine());

            if (nSum <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        } while (nSum <= 0);

        Console.WriteLine($"Formula: 1+2+3+...+{nSum}");
        int sum = 0;

        for (int i = 1; i <= nSum; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Output: {sum}");
        Console.WriteLine();

        int nReverse = 0;
        do
        {
            Console.Write("*Reverse Number Pattern* Please input positive number: ");
            nReverse = int.Parse(Console.ReadLine());

            if (nReverse <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        } while (nReverse <= 0);

        Console.WriteLine("Reverse Number Pattern:");
        for (int i = nReverse; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
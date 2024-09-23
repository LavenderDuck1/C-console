

using System.Globalization;
using System.Security;

class Loops
{
    public static void ForLoops()
    {

        for(int i = 0; i <= 10; i++ )
        {
            Console.WriteLine("Iteration: " + i);
        }
    }

    public static void EvenLoop()
    {
        for(int i = 1; i < 20; i++ )
        {
            if(i % 2 == 1)
            {
            Console.WriteLine(i);
            }
        }
    }
  public static void NestedLoops()
    {
        for(int i = 0; i <= 2; i++ )
        {
            Console.WriteLine("Iteration: " + i);
            for(int j = 0; j <= 2; j++)
            {
                Console.WriteLine("     Iteration: i " + j);
            }
        }
    }

    public static void dowhile()
    {
        do
        {
            Console.Write("Enter a number greate than 0");
            NumberFormatInfo = Convert.ToInt32(Console.ReadLine());
        }
        while (Number <=0);
        Console.WriteLine("You Entered: " + number);
    }

    public static void HealthLoop()
    {
        int health = 100;
        while(health >= 0)
        {
            Console.WriteLine("Player is alive with health" + health);
            health = health - 10;
        }
    }
}
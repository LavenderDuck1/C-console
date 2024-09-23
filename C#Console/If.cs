

class If
{
    public static void Numbers(int number)
    {

        if(number > 0)
        {
            Console.WriteLine("Your number is Postive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Your number is Negative");
        }
        else
        {
            Console.WriteLine("Your number is Zero");
        }
    }

    public static void Health(int health)
    {

        if(health > 75)
        {
            Console.WriteLine("The player is in great condition!");
        }
        else if (health < 50)
        {
            Console.WriteLine("The player is in danger!");
        }
        else
        {
            Console.WriteLine("Game Over.");
        }
    }
}
namespace C#console;

class Character
{
    public string name;
    public int health;
    public int stregnth;

    public static void Players()
    {
        Character player1 = new Character();
        player1.name = "Diego";
        player1.health = 100;
        player1.stregnth = 100;
        Console.WriteLine("PLayer1 Name: " + player1.name);

        Character player2 = new Character()
        player2.name = "Tom";
        player2.health = 50;
        player2.stregnth = 50;
    }
}
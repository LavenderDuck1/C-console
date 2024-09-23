

class Dictionary1
{
    public static void Dict1(string[] args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        phonebook.Add("Alice", "123-456-7890");
        phonebook.Add("Bob", "987-654-3210");

        Console.WriteLine(phonebook["Alice"]);
    }

    public static void Dict2(string[] args)
    {
        Dictionary<string, int> invertory = new Dictionary<string, int>();
        invertory.Add("Apples", 50);
        invertory.Add("Bananas", 30);
        invertory.Add("Mango", 30);
        invertory.Add("Grapes", 12);


        foreach(KeyValuePair<string, int> item in invertory)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }    
}

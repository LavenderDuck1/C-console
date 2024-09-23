
class Var
{
    public static void MyVar()
    {
        string myName = "Diego";
        Console.WriteLine(myName);
    }

    public static void DataType()
    {
        string firstName = "Diego";
        string lastName = "Mendez";
        string wholeName = firstName + lastName;
        int age = 17;
        float gpa = 3.2f;
        double height = 6.2;
        decimal dollar = 100.95m;
        bool is_Teacher = true;
        char grade = 'A';

        //Console.WriteLine(firstName);
        //Console.WriteLine(lastName);
        Console.WriteLine(wholeName);
        Console.WriteLine(age);
        Console.WriteLine(gpa);
        Console.WriteLine(dollar);
        Console.WriteLine(height);
        Console.WriteLine(is_Teacher);
        Console.WriteLine(grade);
    }
}
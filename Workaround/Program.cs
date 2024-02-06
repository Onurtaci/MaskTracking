using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //Variables();

        Person person = new();

        SayHello("John");
        SayHello("Alex");
        SayHello();

        int result = sum(10, 20);

        //Ref-Value Difference was explained
        string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };
        string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };

        cities2 = cities1;
        cities1[0] = "İstanbul";
        Console.WriteLine(cities2[0]);

        Person person1 = new();
        person1.FirstName = "John";
        person1.LastName = "Doe";
        person1.DateOfBirthYear = 1980;
        person1.NationalIdentity = 12345678910;

        Person person2 = new();
        person2.FirstName = "Alex";
        person2.LastName = "Dee";
        person2.DateOfBirthYear = 1985;
        person2.NationalIdentity = 12345678911;


        foreach (var city in cities1)
        {
            Console.WriteLine(city);
        }

        List<string> cities = new List<string> { "Ankara", "İstanbul", "İzmır" };
        cities.Add("Adana");
        cities.ForEach(city => Console.WriteLine(city));


        PttManager pttManager = new(new CitizenManager());
        pttManager.GiveMask(person1);
    }

    public static void SayHello(string name = "noname")
    {
        Console.WriteLine("Hello " + name);
    }

    public static int sum(int number1, int number2)
    {
        int result = number1 + number2;
        Console.WriteLine("Result: " + result);
        return number1 + number2;
    }

    public static void Variables()
    {
        string message = "Hello World";
        double amount = 100000;
        int number = 30;
        bool isAuthenticated = false;

        string name = "John";
        string lastName = "Doe";
        int birthYear = 1980;
        long ssn = 12345678910;

        Console.WriteLine(amount * 1.18);

        Console.WriteLine(amount * 1.18);
    }
}



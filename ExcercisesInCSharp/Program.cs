class Ch1Exercises
{
    static void Main(string[] args)
    {
        //Exercise 5
        Console.WriteLine("Good Day!\n\n\n");

        //Exercise 6
        Console.Write("What is your first name: ");
        string firstName=Console.ReadLine();
        Console.Write("What is your last name: ");
        string lastName=Console.ReadLine();
        Console.WriteLine("Hello, "+firstName+" "+lastName+"\n\n\n");

        //Exercise 7
        byte num1, num2;
        int num3;
        num1 = 1;num2 = 101;num3 = 1001;
        Console.WriteLine(num1);Console.WriteLine(num2);Console.WriteLine(num3);

        //Exercise 8
        Console.WriteLine("\n\n\n" + DateTime.Now);

        //Exercise 9
        Console.WriteLine("\n\n\n" + Math.Sqrt(12345)+"\n\n\n");

        //Exercise 11
        Console.Write("Please enter your age: ");
        byte age=byte.Parse(Console.ReadLine());
        int age2 = age + 10;
        Console.WriteLine("Your name is " + lastName + " " + firstName + ", and in 10yrs you'll be " + age2 + "yrs old");




    }
}
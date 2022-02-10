class Exercise1
{
    static void Main(string[] args)
    {
        System.Console.Write("Please enter a number: ");
        int num1=int.Parse(System.Console.ReadLine());
        System.Console.Write("Please enter another number: ");
        int num2 = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("The two numbers entered are " + num1 + " and " + num2);

        if (num1 > num2)
        {
            num1 += num2;
            num2 = System.Math.Abs(num2-num1);
            num1 -= num2;
            System.Console.WriteLine("The values when switched are: "+num1, num2);
        }
    }
}
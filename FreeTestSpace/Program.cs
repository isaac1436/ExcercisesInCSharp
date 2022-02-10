class FreeTestSpace
{
    static void Main(string[] args)
    {
        //Console.Write("Please enter a number: ");
        //string str=Console.ReadLine();
        //int num;
        //bool parseSuccess= Int32.TryParse(str, out num);
        //Console.WriteLine(parseSuccess ? num * num : "Invalid number");

        ConsoleKeyInfo key= Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Key entered: "+key.KeyChar);
        Console.WriteLine("Special keys: "+key.Modifiers);

    }
}

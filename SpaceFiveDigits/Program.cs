class C3Q28
{
    static void Main(string[] args)
    {
        // declaring variables
        int digit1;
        int digit2;
        int digit3;
        int digit4;
        int digit5;
        int split;

        // prompting user and taking 5 digit integer
        Console.Write("Enter A 5 Digit Integer:  ");
        split = Convert.ToInt32(Console.ReadLine());

        // splitting five digit number
        digit5 = split % 10;
        digit4 = (split / 10) % 10;
        digit3 = (split / 100) % 10;
        digit2 = (split / 1000) % 10;
        digit1 = (split / 10000) % 10;

        Console.WriteLine();    // just for spacing purpose

        // displaying each digit separtely by a single space on screen
        Console.WriteLine(digit1 + " " + digit2 + " " + digit3 + " " + digit4 + " " + digit5);
    }
}

namespace ReverseString;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome in your string reverser!");
        string inputString = "";
        do
        {
            Console.Write("String to reverse : ");
            inputString = Console.ReadLine();
        } while (inputString.Trim() == "");

        string reversedString = "";
        //Reverse Loop
        // for (int i = inputString.Length - 1; i >= 0; i--)
        // {
        //     reversedString += inputString[i];
        // }

        //Forward loop
        for (int i = 0; i < inputString.Length; i++)
        {
            reversedString = inputString[i] + reversedString;
        }


        Console.WriteLine($"The reversed string is : {reversedString}");

        if (reversedString.ToLower() == inputString.ToLower())
        {
            Console.WriteLine("Your word is a palindrome!");
        }
    }
}
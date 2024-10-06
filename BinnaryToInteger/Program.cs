using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Generate a random binary number as a string
        Random random = new Random();
        int binaryLength = 8; // Length of the binary number, e.g., 8 bits
        string binaryString = GenerateRandomBinaryString(random, binaryLength);
        Console.WriteLine($"Generated binary number: {binaryString}");

        // Step 2: Convert the binary string to an integer manually
        int integerValue = ConvertBinaryToInteger(binaryString);
        Console.WriteLine($"Integer value of the binary number {binaryString} is: {integerValue}");

        Console.ReadLine();
    }

    // Method to generate a random binary string of specified length
    static string GenerateRandomBinaryString(Random random, int length)
    {
        char[] binaryArray = new char[length];

        for (int i = 0; i < length; i++)
        {
            binaryArray[i] = random.Next(0, 2) == 0 ? '0' : '1';
        }

        return new string(binaryArray);
    }

    // Method to convert a binary string to an integer manually
    static int ConvertBinaryToInteger(string binaryString)
    {
        int result = 0;
        int power = 1; // Represents 2^0 initially

        // Traverse the binary string from right to left
        for (int i = binaryString.Length - 1; i >= 0; i--)
        {
            if (binaryString[i] == '1')
            {
                result += power;
            }
            power *= 2; // Update power to the next bit (2^n)
        }

        return result;
    }
}

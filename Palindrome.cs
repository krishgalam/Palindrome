public static class Palindrome
{
    public static void CheckIfPalinDrome(int paramValue)
    {
        // Validation

        // Check basic length if lenght is even not a palindrome
        int paramLength = paramValue.ToString().Length;
        if (paramLength == 1)
        {
            Console.WriteLine("Success: Given value is a Palindrome");
            return;
        }
        int splitValueIndex = 0;
        Console.WriteLine("Halflength" + (paramLength) / 2);
        splitValueIndex = paramLength % 2 == 0 ? (paramLength) / 2 : (paramLength - 1) / 2;
        Console.WriteLine("splitValueIndex " + splitValueIndex);
        Console.WriteLine(splitValueIndex);
        int counter = paramLength - 1;
        var paramValueCharArray = paramValue.ToString().ToCharArray();
        for (int i = 0; i < splitValueIndex; i++)
        {
            Console.WriteLine("FirstHalf " + paramValueCharArray[i]);
            Console.WriteLine("SecondHalf " + paramValueCharArray[counter]);

            if (paramValueCharArray[i] == paramValueCharArray[counter])
            {
                counter--;
                if (counter <= 1)
                {
                    Console.WriteLine("Success:"+ paramValue +" Given value is a Palindrome");
                }

            }
            else
            {
                Console.WriteLine("Invalid:" + paramValue + "Given value is not a Palindrome");
            }
        }
    }
}
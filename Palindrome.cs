public static class Palindrome
{
    public static void CheckIfPalinDrome(int paramValue)
    {
        // Check basic length if lenght is even not a palindrome
        int paramLength = paramValue.ToString().Length;
        if (paramLength == 1)
        {
            Console.WriteLine("Success: Given value " + paramValue + " is a Palindrome");
            return;
        }
        int splitValueIndex = 0;
        splitValueIndex = paramLength % 2 == 0 ? (paramLength) / 2 : (paramLength - 1) / 2;
        int counter = paramLength - 1;
        var paramValueCharArray = paramValue.ToString().ToCharArray();
        for (int i = 0; i < splitValueIndex; i++)
        {
            if (paramValueCharArray[i] == paramValueCharArray[counter])
            {
                counter--;
                if (counter <= 1)
                {
                    Console.WriteLine("Success: Given value " + paramValue + " is a Palindrome");
                }

            }
            else
            {
                Console.WriteLine("Invalid: Given value " + paramValue + " is not a Palindrome");
            }
        }
    }
}
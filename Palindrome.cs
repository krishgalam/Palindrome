public static class Palindrome
{
    public static void CheckIfPalinDrome(string paramValue)

     {
        // Check basic length if lenght is even not a palindrome
        int paramLength = paramValue.Length;
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

    public static bool IsPalindrome(int x)
    {
        if (x == 0)
            return true;
        if (x < 0 || x % 10 == 0)
            return false;
        int v = 0;
        while (x > v)
        {
            Console.WriteLine("Before X :" + x);
            Console.WriteLine("Before v :" + v);

            v = x % 10 + v * 10;
            x = x / 10;
            Console.WriteLine("after X :" + x);
            Console.WriteLine("after v :" + v);

        }
        return x == v || v / 10 == x;

    }
}

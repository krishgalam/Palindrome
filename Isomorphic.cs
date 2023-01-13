public static class Isomorphic
{
    public static bool IsIsomorphic()
    {
        var str1 = "abcd";
        var str2 = "dbeb";

        // Validation
        // Null and Empty checks
        if(String.IsNullOrEmpty(str1) && !String.IsNullOrEmpty(str2))
        {
            return false;
        }

        if (!String.IsNullOrEmpty(str1) && String.IsNullOrEmpty(str2))
        {
            return false;
        }

        // Identify lenths of boths variables if not matched return false
        if(str1.Length != str2.Length){
            return false;
        }

        // Get the characters length
        var list1 = str1.ToCharArray();
        var distinctList = list1.Distinct();

        var list2 = str2.ToCharArray();
        var distinctList2 = list2.Distinct();

        if(list1.Count() == list2.Count())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
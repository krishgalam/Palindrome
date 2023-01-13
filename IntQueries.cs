public static class IntQueries
{   
    public static int FindOutSortOrderIndex(int[] arrayInt, int target)
    {
        if(arrayInt.Any(x=> x == target))
        {
            return -1 ;
        }
        else
        {
            arrayInt = arrayInt.OrderBy(a=>a).ToArray();
            var counter = arrayInt.Length - 1;
            if(arrayInt[counter] < target)
            {
                 return arrayInt.Length;
            }

            for(int i=0; i<arrayInt.Length; i++)
            {
                if(arrayInt[i] > target  )
                {
                    return i;
                }
                if( arrayInt[counter] < target)
                {
                    return counter;
                }
                counter--;
            }
            return arrayInt.Length;
        }    
    }
}
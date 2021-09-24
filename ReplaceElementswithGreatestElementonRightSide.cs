public class Solution 
{
    public int[] ReplaceElements(int[] arr) 
    {
        int velikost = arr.Length;
        
        int maxPrava = arr[velikost-1];
        
        if (arr == null || velikost == 0) 
        {
            return null;
        }
        
        for (int i = velikost - 2; i >= 0; i--)
        {
            int prvek = arr[i];
            arr[i] = maxPrava;
            if(maxPrava < prvek)
            {
                maxPrava = prvek;
            }
        }
        arr[velikost-1]=-1;
        
     return arr;   
    }
}

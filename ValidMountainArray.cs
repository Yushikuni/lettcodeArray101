public class Solution 
{
    public bool ValidMountainArray(int[] arr) 
    {
        int vrchol = 0, leva = 0, prava = 0;
        int pocet = arr.Length;
        while((vrchol < pocet - 1) && (arr[vrchol] < arr[vrchol + 1]))
        {
            vrchol++;
            leva++;
        }
        if ((vrchol == 0) || (vrchol == pocet - 1))
        {
            return false;
        }
        while((vrchol < pocet - 1) && (arr[vrchol] > arr[vrchol + 1]))
        {
            vrchol++;
            prava++;
        }        
        return (leva*prava > 0) && (vrchol == pocet - 1);   
    }
}

public class Solution 
{
    public bool CheckIfExist(int[] arr) 
    {
        if (arr == null || arr.Length == 0) 
        {
             return false;
        }
        for (int i = 0; i < arr.Length; ++i) 
        {
            for(int j = 0; j < i; ++j)
            {
                if(arr[i] == 2*arr[j] || arr[j] % 2 == 0)
                {
                    return true;
                }
            }
        }        
        return false;
    }
}

public class Solution 
{
    public void DuplicateZeros(int[] arr) 
    {
        for(int i = 0; i < arr.Length; ++i)
        {
            if(arr[i] == 0)
            {
                arr[i+1] = arr[i];
            }
        }
    }
}

public class Solution 
{
    public void DuplicateZeros(int[] arr) 
    {
        int[] pole = new int[20];
        
        for(int i = 0; i < pole.Length; ++i)
        {
            pole[i] = arr[i];
            if(arr[i] == 0)
            {
                pole[i+1] = arr[i];
            }
        }

    }
}

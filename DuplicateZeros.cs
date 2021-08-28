public class Solution 
{
    public void DuplicateZeros(int[] arr) 
    {
        //nové pole o velikosti 20
        int[] pole = new int[20];
        //kopie pole
        for(int i = 0; i < arr.Length; ++i)
        {
            pole[i] = arr[i];
        }
        //uprava pole
        for(int i = 0; i< pole.Length; ++i)
        {
            if(pole[i] == 0)
            {
                pole[i+1] = pole[i];
            }
        }
    }
}

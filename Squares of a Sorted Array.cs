public class Solution 
{
    public int[] SortedSquares(int[] nums) 
    {
        int[] sortCisla = new int [nums.Length];
        for(int i = 0; i<nums.Length; ++i)
        {
           sortCisla[i] = nums[i]* nums[i];    
        }
        
        Array.Sort(sortCisla);
        return sortCisla;
    }
}

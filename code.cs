public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
        int same = 0;
        for(int i = 0; i < nums.Length; i++)
        {
           int n = nums[i];
            for(int j = 0; j < nums.Length; j++)
            {
                int o = nums[j];
                if(n == o)
                {
                    ++same;
                }
                else
                {
                    same = 0;
                }
            }
        }
        return same;
    }
}

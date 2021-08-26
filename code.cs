public class Solution 
{
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
       /* int same = 0;
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
        return same;*/
        
        int same = 0;
        int max = 0;
        for(int i = 0; i < nums.Length; i++)
        {
           if(nums[i] == 1)
           {
               max +=1;
           }
            else
            {
                same = Math.Max(same, max);
                max = 0;
            }           
        }
        return Math.Max(same, max);
    }
}

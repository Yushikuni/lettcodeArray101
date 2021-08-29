public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int delka = 0;
        int momentalne = 0;
        
        for(int i = 0; i < nums.Length; ++i)
        {
            if(nums[i] != nums[momentalne])
            {
                nums[momentalne];
                nums[i] = nums[i];  
                ++delka;
                ++momentalne;
            }
        }
        
        return delka+1;
    }
}

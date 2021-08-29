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
                nums[momentalne+1];
                nums[i] = nums[i];
                //nums[momentalne+1];                
                ++delka;
                ++momentalne;
            }
        }
        
        return delka+1;
    }
}

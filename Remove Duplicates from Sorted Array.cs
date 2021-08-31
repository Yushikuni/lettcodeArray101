public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int delka = 0;
        int momentalne = 0;
        
        for(int i = 0; i < nums.Length; ++i)
        {
            int temp = -1;
            if(nums[i] != nums[momentalne])
            {
                temp = nums[momentalne];
                nums[momentalne] = nums[i];
                nums[i] = temp;
                ++delka;
                ++momentalne;                
            }
        }
        
        return delka+1;
    }
}

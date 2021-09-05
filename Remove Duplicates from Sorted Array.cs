public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        int delka = nums.Length;
        /*int delka = 0;
        int momentalne = 0;
        
        for(int i = 0; i < nums.Length; ++i)
        {
            int temp = -1;
            if(nums[i] != nums[momentalne])
            {
                temp = nums[i];
                nums[i] = nums[momentalne + 1]; 
                nums[momentalne + 1] = temp;                
                delka++;
                momentalne++;
                temp = -1;
            }
        } 
        return delka + 1;*/
        for(int i = delka - 2; i >= 0; i--)
        {
            if(nums[i] == nums[i + 1])
            {
                for(int j = i + 1; j < delka; j++)
                {
                    nums[j - 1] = nums[j];
                }
                delka--;
            }
        }
        return delka;
    }
}

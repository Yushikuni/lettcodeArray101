public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        int i = 1;
        List<int> returnNums = new List<int>();
         List<int> numList = nums.ToList();
        while(i <= numList.Count){
            if(!numList.Contains(i)){
                returnNums.Add(i);
            }
            i++;
        }
        return returnNums;
    }
}

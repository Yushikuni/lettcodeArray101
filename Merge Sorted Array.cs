public class Solution 
{
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        int[] arr3 = new int[m+n];
        Array.Copy(nums1, arr3, m);
        Array.Copy(nums2, 0, arr3, m, n);
        Array.Copy(arr3,nums1, arr3.Length);
        //konecne serazeni
        Array.Sort(nums1);
    }
}

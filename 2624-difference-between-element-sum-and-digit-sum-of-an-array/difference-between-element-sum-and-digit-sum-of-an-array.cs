public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int digitSum=0;
        int elementSum=0;
        int absoluteDifference=0;
        for(int i=0;i<nums.Length;i++)
        {
          elementSum+=nums[i];
            while(nums[i]>0)
            {
                digitSum+=nums[i]%10;
                nums[i]/=10;
            }
        }
        absoluteDifference=elementSum-digitSum;
        return absoluteDifference;
    }
}
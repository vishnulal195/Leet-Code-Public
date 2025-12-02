public class Solution {
    public int ArraySign(int[] nums) {
        int sign=0;
        for(int i=0;i<nums.Length;i++)
        {
           if(nums[i]==0)
           {
            return 0;
           }
           else if(nums[i]<0)
           {
             sign++;
           }
        }
        return signFunc(sign);
    }

    public int signFunc(int signCount)
    {
      if(signCount%2==0)
      {
        return 1;
      }
      else{
        return -1;
      }
    }
}
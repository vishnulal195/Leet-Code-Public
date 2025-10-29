public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int left =0;
        int right =numbers.Length-1;
        while(left<right)
        {
          int sum = numbers[left]+numbers[right];
          if(sum==target)
          {
           return new int[]{left+1,right+1};
          }
          else if(sum<target)
          {
           left++;
          }
          else if(sum>target)
          {
            right--;
          }
        }
        return  Array.Empty<int>();
    }
}
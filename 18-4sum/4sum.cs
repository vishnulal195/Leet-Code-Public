public class Solution {
  public IList < IList < int >> FourSum(int[] nums, int target) {
    IList < IList < int >> result = new List < IList < int >> ();
    Array.Sort(nums);
    for (int i = 0; i < nums.Length-3; i++) {
      if (i>0 && nums[i] == nums[i - 1]) continue;
      for (int j = i + 1; j < nums.Length-2; j++) {
        if (j>i+1 && nums[j] == nums[j - 1]) continue;
        int left = j + 1;
        int right = nums.Length - 1;
        while(left<right)
        {
long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
        if (target == sum) 
        {
         result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
          left++;
          right--;
          while (left < right && nums[left] == nums[left - 1]) {
            left++;            
          }
          while (right > left && nums[right] == nums[right + 1])
             {
              right--;
            }
        }
        else if (sum < target && left < right) {
        left++;
        while (left < right && nums[left] == nums[left - 1]) {
            left++;            
          }
      }
      else if (sum > target && right > left) 
      {
        right--;
         while (right > left && nums[right] == nums[right + 1])
             {
              right--;
            }
      }
        }
        
      }      
    }
    return result;
  }
}
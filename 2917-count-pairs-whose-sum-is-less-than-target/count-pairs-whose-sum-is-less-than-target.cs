public class Solution {
    public int CountPairs(IList<int> nums, int target) {
              
        var arr = nums.OrderBy(x => x).ToArray();

        int left = 0;
        int right = arr.Length - 1;
        int count = 0;

        
        while (left < right)
        {
            int sum = arr[left] + arr[right];

            if (sum < target)
            {
               
                count += (right - left);
                left++;   
            }
            else
            {
                right--;  
            }
        }

        return count;
    }
}
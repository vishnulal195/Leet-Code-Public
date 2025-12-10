public class Solution {
    public int Search(int[] nums, int target) {
         int lo = 0, hi = nums.Length - 1;
        while (lo <= hi) {
            int mid = lo + ((hi - lo) >> 1); // avoids overflow
            if (nums[mid] == target) return mid;
            if (nums[mid] < target) lo = mid + 1;
            else hi = mid - 1;
        }
        return -1;
    }
}
public class Solution {
    public int SmallestIndex(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            if (DigitSum(nums[i]) == i) return i;
        }
        return -1;
    }
    private int DigitSum(int x) {
        int sum = 0;
        while (x > 0) {
            sum += x % 10;
            x /= 10;
        }
        return sum;
    }
}
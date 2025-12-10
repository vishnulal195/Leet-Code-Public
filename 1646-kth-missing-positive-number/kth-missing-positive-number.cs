public class Solution {
    public int FindKthPositive(int[] arr, int k) {
         int missing = 0;  
        int expected = 1; 

        foreach (int num in arr) {
            while (expected < num) {
                missing++;
                if (missing == k) return expected;
                expected++;
            }
            expected = num + 1;
        }
        return arr[arr.Length - 1] + (k - missing);
    }
}
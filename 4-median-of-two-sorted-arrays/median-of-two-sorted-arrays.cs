public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1); // ensure nums1 is smaller

        int m = nums1.Length;
        int n = nums2.Length;
        int low = 0, high = m;
        double median = 0.0;

        while (low <= high)
        {
            int i = (low + high) / 2;
            int j = (m + n + 1) / 2 - i;

            int left1 = (i == 0) ? int.MinValue : nums1[i - 1];
            int right1 = (i == m) ? int.MaxValue : nums1[i];

            int left2 = (j == 0) ? int.MinValue : nums2[j - 1];
            int right2 = (j == n) ? int.MaxValue : nums2[j];

            if (left1 <= right2 && left2 <= right1)
            {
                if ((m + n) % 2 == 0)
                    median = (Math.Max(left1, left2) + Math.Min(right1, right2)) / 2.0;
                else
                    median = Math.Max(left1, left2);
                break;
            }
            else if (left1 > right2)
                high = i - 1;
            else
                low = i + 1;
        }

        return median;
    }
}

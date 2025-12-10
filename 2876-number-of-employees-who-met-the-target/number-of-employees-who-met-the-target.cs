public class Solution {
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target) {
        int count = 0;
        foreach (int h in hours) {
            if (h >= target) count++;
        }
        return count;
    }
}
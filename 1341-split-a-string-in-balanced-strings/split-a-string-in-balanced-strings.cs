public class Solution {
    public int BalancedStringSplit(string s) {
        int count = 0;
        int result = 0;

        foreach (char c in s) {
            if (c == 'L') count++;
            else count--;

            if (count == 0) result++;
        }

        return result;
    }
}
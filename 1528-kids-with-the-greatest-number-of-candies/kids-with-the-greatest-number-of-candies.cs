public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
         int n = candies.Length;
        IList<bool> res = new List<bool>(n);
        int max = int.MinValue;
        for (int i = 0; i < n; i++) if (candies[i] > max) max = candies[i];
        for (int i = 0; i < n; i++) res.Add(candies[i] + extraCandies >= max);
        return res;
    }
}
public class Solution {
    public int MinOperations(IList<int> nums, int k) 
    {
    var seen = new HashSet<int>();
        int n = nums.Count;
        for (int i = n - 1; i >= 0; --i) {
            int v = nums[i];
            if (v >= 1 && v <= k) seen.Add(v);
            if (seen.Count == k) return n - i;
        }
        return n;  
        
    }
}
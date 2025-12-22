public class Solution {
    public int MaximumLengthSubstring(string s) {
        int left=0;
        int maxLength=0;
        int[]frequency = new int[26];
        for (int right=0; right<s.Length;right++)
        {
            int rChar=s[right]-'a';
            frequency[rChar]++;
            while(frequency[rChar]>2)
            {
                int lChar=s[left]-'a';
                frequency[lChar]--;
                left++;
            }
            maxLength= Math.Max(maxLength,right-left+1);
        }
        return maxLength;
    }
}
public class Solution {
    public int MaxFreqSum(string s) {
         int[] freq = new int[26];
        foreach (char c in s) freq[c - 'a']++;

        int maxVowel = 0, maxConsonant = 0;
        string vowels = "aeiou";
        for (int i = 0; i < 26; i++) {
            char c = (char)('a' + i);
            if (vowels.IndexOf(c) >= 0)
                maxVowel = Math.Max(maxVowel, freq[i]);
            else
                maxConsonant = Math.Max(maxConsonant, freq[i]);
        }
        return maxVowel + maxConsonant;
    }
}
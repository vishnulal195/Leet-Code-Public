public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        int i = 0, j = 0;     
        int p = 0, q = 0;     

        while (i < word1.Length && j < word2.Length) {
            if (word1[i][p] != word2[j][q]) return false;

            p++;
            q++;

            if (p == word1[i].Length) {
                p = 0;
                i++;
            }
            if (q == word2[j].Length) {
                q = 0;
                j++;
            }
        }

        
        return (i == word1.Length && j == word2.Length);
    }
}
public class Solution {
    public string MergeAlternately(string word1, string word2) {
        
        int minLength=Math.Min(word1.Length,word2.Length);
        string merged="";
        for(int i=0;i<minLength;i++)
        {
            merged+=word1[i].ToString()+word2[i].ToString();
        }
        if(word1.Length>word2.Length)
        {
            merged+=word1.Substring(minLength);
        }
        else if(word2.Length>word1.Length)
        {
          merged+=word2.Substring(minLength);
        }
        return merged;
    }
}
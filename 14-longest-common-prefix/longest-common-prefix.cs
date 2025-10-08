public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string commonPrefix = strs[0];  
                    
        for(int i=1;i<strs.Length;i++)
        {
           int j=0;
           string secondWord=strs[i];
           while(j<secondWord.Length && j<commonPrefix.Length && commonPrefix[j]==secondWord[j])
           {
            j++;            
           }
        var sb = new System.Text.StringBuilder();
       for(int k=0; k<j; k++)
        {
         sb.Append(commonPrefix[k]);
        }
         commonPrefix=sb.ToString();
        }
        if(commonPrefix==""){
            return "";
        }            
        return commonPrefix;
    }
}
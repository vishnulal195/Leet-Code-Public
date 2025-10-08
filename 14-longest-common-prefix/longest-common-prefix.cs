public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string commonPrefix = strs[0];
        string firstWord=commonPrefix;
         
         int prefixLength=0;
        for(int i=1;i<strs.Length;i++)
        {
           int j=0;
           string secondWord=strs[i];
           while(j<secondWord.Length && j<commonPrefix.Length && commonPrefix[j]==secondWord[j])
           {
            j++;            
           }
        prefixLength=j;
       string result="";
       for(int k=0; k<prefixLength; k++)
        {
         result+=commonPrefix[k];
        }
         commonPrefix=result;
        }
        if(commonPrefix==""){
            return "";
        }            
        return commonPrefix;
    }
}
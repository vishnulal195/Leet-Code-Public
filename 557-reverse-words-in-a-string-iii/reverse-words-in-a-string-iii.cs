public class Solution {
    public string ReverseWords(string s) {
        var parts = s.Split(' ');
        for (int i = 0; i < parts.Length; i++) {
            char[] arr = parts[i].ToCharArray();
            Array.Reverse(arr);
            parts[i] = new string(arr);
        }
        return string.Join(' ', parts); 
    }
}
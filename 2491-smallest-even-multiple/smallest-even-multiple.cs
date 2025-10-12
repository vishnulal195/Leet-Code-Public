public class Solution {
    public int SmallestEvenMultiple(int n) {
        int smallestEvenMultiple=1;
        if(n%2==0)
        {
            return n;
         }
        else
        {
            smallestEvenMultiple=2*n;
            return smallestEvenMultiple;
        }
        
        
    }
}
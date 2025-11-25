public class Solution {
    public int Fib(int n) {
        if(n>=2)
        {            
        return Fib(n-1)+Fib(n-2);
        }
        else if(n==1)
        {
         return 1;
        }
        else
        {
         return 0;
        }
    }
}
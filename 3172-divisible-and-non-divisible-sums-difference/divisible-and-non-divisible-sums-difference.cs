public class Solution {
    public int DifferenceOfSums(int n, int m) {
         int sumDiv = 0, sumNonDiv = 0;

        for (int i = 1; i <= n; i++) {
            if (i % m == 0)
                sumDiv += i;
            else
                sumNonDiv += i;
        }

        return sumNonDiv - sumDiv;
    }
}
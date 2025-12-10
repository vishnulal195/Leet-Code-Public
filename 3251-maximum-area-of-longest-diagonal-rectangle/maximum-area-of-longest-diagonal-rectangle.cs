public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        double bestDiagonal = 0;
        int bestArea = 0;

        foreach (var rect in dimensions) {
            int l = rect[0];
            int w = rect[1];

            double diagonal = Math.Sqrt((long)l * l + (long)w * w);
            int area = l * w;

            if (diagonal > bestDiagonal || 
               (diagonal == bestDiagonal && area > bestArea)) 
            {
                bestDiagonal = diagonal;
                bestArea = area;
            }
        }

        return bestArea;
    }
}
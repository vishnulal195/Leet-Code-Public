public class Solution {
    public int MaxArea(int[] height)
     {
       int i=0;
       int j=height.Length-1;
       int area=0;
       int highestArea=0;
       while(i!=j)
       {
        int minVal = (height[i] < height[j]) ? height[i] : height[j];
        area = (j-i)*minVal;
      if(height[i]<=height[j])
      {
         i++;
      }
      else
      {
        j--;
      }
      if(area>highestArea){

        highestArea=area;
      }
       }
     return highestArea;
    }
}
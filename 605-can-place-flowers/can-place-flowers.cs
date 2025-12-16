public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
      
       int index=0;
       
       while(index<flowerbed.Length)
       {
       if(flowerbed[index]==0 )
       {
        bool left = (index==0||flowerbed[index-1]==0);
        bool right = (index==flowerbed.Length-1||flowerbed[index+1]==0);
        if(left&&right)
        {
            flowerbed[index]=1;
            n--;
            if(n==0)
            {
              return true;
            }
        }
       }
       index++;
       }
       return n<=0;       
    }
}
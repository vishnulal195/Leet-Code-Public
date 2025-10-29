public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        int[] indices=new int[2];
       for(int i=0; i<numbers.Length-1; i++)
       {
        int right = numbers.Length-1;
        while(i<right)
        {
          int sum = numbers[i]+numbers[right];
        if(sum ==target)
        {
         indices= new int[] {i+1,right+1};
         return indices;
        }
        else if(sum<target)
        {
          i++;
        }
        else if(sum>target){
            right--;
        }
        }
        
       } 
       return indices;
    }
}
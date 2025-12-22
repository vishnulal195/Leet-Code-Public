public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     int firstCounter=0;
     int secondCounter=1;   
     while(firstCounter < nums.Length){
        if(secondCounter<nums.Length){
            if(nums[firstCounter]+nums[secondCounter]==target) 
            break;
            secondCounter++;
        }
        else{
            firstCounter++;
            secondCounter=firstCounter+1;
        }
     }
     return new int[]{firstCounter,secondCounter};
    }
}
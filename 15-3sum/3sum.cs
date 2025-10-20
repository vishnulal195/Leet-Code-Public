public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) 
    {
        IList<IList<int>> listOfLists = new List<IList<int>>();
        if (nums.Length < 3) return listOfLists;

        nums = QuickSort(nums, 0, nums.Length - 1);

        for (int x = 0; x < nums.Length - 2; x++)
        {
            if (x > 0 && nums[x] == nums[x - 1]) continue; // skip duplicates
            int fixedNumber = nums[x];
            int leftNumber = x + 1;
            int rightNumber = nums.Length - 1;

            while (leftNumber < rightNumber)
            {
                int sum = fixedNumber + nums[leftNumber] + nums[rightNumber];

                if (sum == 0)
                {
                    listOfLists.Add(new List<int> { fixedNumber, nums[leftNumber], nums[rightNumber] });

                    // skip duplicates safely
                    while (leftNumber < rightNumber && nums[leftNumber] == nums[leftNumber + 1]) leftNumber++;
                    while (leftNumber < rightNumber && nums[rightNumber] == nums[rightNumber - 1]) rightNumber--;

                    leftNumber++;
                    rightNumber--;
                }
                else if (sum < 0)
                {
                    leftNumber++;
                }
                else
                {
                    rightNumber--;
                }
            }
        }

        return listOfLists;
    }

    public int[] QuickSort(int[] array, int leftValue, int rightValue)
    {
        if (leftValue < rightValue)
        {
            int pivotIndex = Partition(array, leftValue, rightValue);
            QuickSort(array, leftValue, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, rightValue);
        }
        return array;
    }

    public int Partition(int[] nums, int leftValue, int rightValue)
    {
        int i = leftValue - 1;
        for (int j = leftValue; j < rightValue; j++)
        {
            if (nums[j] < nums[rightValue])
            {
                i++;
                Swap(nums, i, j);
            }
        }
        Swap(nums, i + 1, rightValue);
        return i + 1;
    }

    public void Swap(int[] nums, int leftValue, int rightValue)
    {
        int temp = nums[leftValue];
        nums[leftValue] = nums[rightValue];
        nums[rightValue] = temp;
    }
}

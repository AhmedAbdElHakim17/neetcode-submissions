public class Solution {
    public void SortColors(int[] nums) {
        var arr = new int[3];
        foreach(var n in nums)
        {
            arr[n]++;
        }
        var index = 0;
        for(int i = 0; i < 3;i++)  // [1,2,1]
        {
            while(arr[i]-- > 0) // arr[0] = 1
            {
                nums[index++] = i; // nums[0] = 0
            }
        }
    }
}
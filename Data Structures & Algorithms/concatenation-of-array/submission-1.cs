public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var arr = new int[2 * nums.Length]; // 8
        for(int i = 0; i < nums.Length; i++)
        {
            arr[i] = arr[nums.Length + i] = nums[i];
        }
        return arr;
    }
}
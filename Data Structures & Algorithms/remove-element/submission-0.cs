public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        int y = 0;
        while (k < nums.Length)
        {
            if (nums[k] != val)
            {
                nums[y] = nums[k];
                y++;
                k++;
            }
            else
                k++;
        }
        return y;
    }
}
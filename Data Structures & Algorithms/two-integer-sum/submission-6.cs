public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Using IndexOf()
        // If I have 3 and used IndexOf (7-3 = 4), I'll get the other Index
        // then return int[nums[3],Index];
        for(int i = 0; i < nums.Length; i++)
        {
            int res = target - nums[i];
            var ind = Array.IndexOf(nums, res, i+1);
            if (ind != -1) // the value when no matching result
                return [i, ind];
        }
        return null;
    }
}

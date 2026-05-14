public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            var res = target - nums[i];
            var ind = Array.IndexOf(nums,res,i+1);
            if(ind != -1)
                return [i, ind];
        }
        return [];
    }
}

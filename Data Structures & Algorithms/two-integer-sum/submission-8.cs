public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            if(dic.ContainsKey(nums[i]))
            {
                var ind = Array.IndexOf(nums, dic[nums[i]]);
                return [ind,i];
            }
            dic[target - nums[i]] = nums[i];
        }
        return [];
    }
}
// 4,3
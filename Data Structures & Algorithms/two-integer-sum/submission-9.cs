public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            dic[nums[i]] = i;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if(dic.ContainsKey(diff) && dic[diff] != i)
                return [i, dic[diff]];
        }
        return [];
    }
}

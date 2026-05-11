public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums.Length == 0)
            return false;
        var set = new HashSet<int>(nums.Length);
        foreach (var n in nums)
        {
            if(!set.Add(n))
                return true;
        }
        return false;
    }
}
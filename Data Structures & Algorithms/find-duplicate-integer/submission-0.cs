public class Solution {
    public int FindDuplicate(int[] nums) {
        var set = new HashSet<int>();
        foreach (var n in nums)
        {
            if(!set.Add(n))
                return n;
        }
        return 0;
    }
}

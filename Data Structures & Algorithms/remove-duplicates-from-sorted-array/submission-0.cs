public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var set = new HashSet<int>(nums.Length);
        int k = 0;
        foreach(var n in nums)
        {
            if(set.Add(n))
            {
                nums[k] = n;
                k++;
            }
        }
        return k;
    }
}
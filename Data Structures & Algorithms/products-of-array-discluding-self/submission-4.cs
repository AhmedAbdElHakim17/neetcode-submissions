public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        int product = 1, zeroCount = 0;
        foreach (var n in nums)
        {
            if(n == 0)
                zeroCount++;
            else
                product *= n;
        }
        if (zeroCount > 1)
            return new int [nums.Length];
        
        for (int i = 0; i < nums.Length; i++)
        {
            if(zeroCount > 0)
                result[i] = (nums[i] == 0) ? product : 0;
            else
                result[i] = product / nums[i];
        }
        return result;
    }
}

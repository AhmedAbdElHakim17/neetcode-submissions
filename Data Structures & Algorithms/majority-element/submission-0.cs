public class Solution {
    public int MajorityElement(int[] nums) {
        var dic = new Dictionary<int,int>();
        foreach (var n in nums)
        {
            if(dic.ContainsKey(n))
                dic[n] += 1;
            else
                dic[n] = 1;
        }
        foreach (var kvp in dic)
        {
            if (kvp.Value > nums.Length/2)
                return kvp.Key;
        }
        return 0;
    }
}
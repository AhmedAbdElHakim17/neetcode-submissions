public class Solution {
    public int MajorityElement(int[] nums) {
        var dic = new Dictionary<int, int>();
        var max = 0;
        foreach(var n in nums)
        {
            if(!dic.ContainsKey(n))
            {
                dic[n] = 1;
            }
            dic[n]++;
            max = Math.Max(max, dic[n]);
        }
        return dic.Where(kvp => kvp.Value == max)
        .Select(kvp => kvp.Key).FirstOrDefault();
    }
}
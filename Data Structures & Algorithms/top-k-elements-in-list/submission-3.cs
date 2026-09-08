public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary<int, int>();
        foreach(var n in nums)
        {
            if(!dic.ContainsKey(n))
                dic[n] = 0;
            dic[n]++;
        }
        return dic.OrderByDescending(x => x.Value)
                  .Select(x => x.Key)
                  .Take(k).ToArray();
        
    }
}

public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++)
        {
            var chars = strs[i].ToCharArray();
            Array.Sort(chars);
            var sorted = new string(chars);
            if(dic.ContainsKey(sorted))
            {
                dic[sorted].Add(strs[i]);
            }
            else
            {
                dic[sorted] = new List<string>(){strs[i]};
            }
        }
        return dic.Values.ToList();
    }
}

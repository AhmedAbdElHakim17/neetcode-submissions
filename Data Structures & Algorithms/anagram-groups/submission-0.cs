public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // var outp = new List<List<string>>();
        var dic = new Dictionary<string, List<string>>();
        for(int i = 0; i < strs.Length; i++)
        {
            var st = strs[i];
            var arr = strs[i].ToCharArray();
            Array.Sort(arr);
            var key = new String(arr);
            if(dic.ContainsKey(key))
                dic[key].Add(st);
            else
                dic[key] = new List<string>{st};
        }
        var outp = new List<List<string>>(dic.Values);
        // for (int i = 0; i < strs.Length; i++)
        // {
        //     var st = strs[i];
        //     var arr = strs[i].ToCharArray();
        //     Array.Sort(arr);
        //     var key = new String(arr);
        //     if(dic.ContainsKey(key))
        //         outp.Add(dic[strs[i]]);
        // }
        return outp;
    }
}

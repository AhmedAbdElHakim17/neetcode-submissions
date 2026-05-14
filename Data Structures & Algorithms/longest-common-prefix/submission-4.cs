public class Solution {
    public string LongestCommonPrefix(string[] strs) {
            if(strs.Length == 1)
        return strs[0];
        var count = new int[10000];
var newstrs = new List<char>();
var first = strs[0].ToCharArray();
for (int i = 1; i < strs.Length; i++)
{
    var chars = strs[i].ToCharArray();
    var len = Math.Min(first.Length, chars.Length);
    for (int x = 0; x < len; x++)
    {
        if (chars[x] == first[x])
        {
            count[x] ++;
        }
        else
        {
            break;
        }
    }
}
for (int i = 0; i < count.Length; i++)
{
    if(count[i] == strs.Length - 1)
        newstrs.Add(first[i]);
}
return new string(newstrs.ToArray());
    }
}
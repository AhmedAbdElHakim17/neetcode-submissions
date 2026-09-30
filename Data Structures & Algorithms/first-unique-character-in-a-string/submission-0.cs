public class Solution {
    public int FirstUniqChar(string s) {
        var chars = new int [26];
        for(int i = 0; i < s.Length;i++)
        {
            chars[s[i] - 'a']++;
        }
        for(int i = 0; i < s.Length;i++)
        {
            if(chars[s[i] - 'a'] == 1)
                return i;
        }
        return -1;
    }
}
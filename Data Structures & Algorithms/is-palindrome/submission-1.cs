public class Solution {
    public bool IsPalindrome(string s) {
        int r = 0;
        int l = s.Length - 1;
        while(r < l)
        {
            if(!char.IsLetterOrDigit(s[r]))
            {
                r++;
                continue;
            }
             if(!char.IsLetterOrDigit(s[l]))
            {
                l--;
                continue;
            }
            {
                if(char.ToLower(s[r]) != char.ToLower(s[l]))
                    return false;
                r++;
                l--;
            }
        }
        return true;
    }
}

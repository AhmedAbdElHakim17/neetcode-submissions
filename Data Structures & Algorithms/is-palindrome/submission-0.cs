public class Solution {
    public bool IsPalindrome(string s) {
        string str = "";
        foreach(var c in s)
            if(Char.IsLetterOrDigit(c))
                str+= Char.ToLower(c);
        return str == new String(str.Reverse().ToArray());
    }
}

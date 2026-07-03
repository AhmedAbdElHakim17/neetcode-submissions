public class Solution {
    public void ReverseString(char[] s) {
        int l = 0;
        int r = s.Length - 1;
        for (int i = 0; i < s.Length/2; i++)
        {
            var x = s[l];
            s[l] = s[r];
            s[r] = x;
            l++;
            r--;
        }
    }
}
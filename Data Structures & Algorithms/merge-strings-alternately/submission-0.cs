public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string s = "";
        var len = Math.Max(word1.Length, word2.Length);
        for (int i = 0; i < len; i++)
        {
            if(i == word1.Length)
            {
                s+= word2.Substring(i);
                return s;
            }
            else if (i == word2.Length)
            {
                s+= word1.Substring(i);
                return s;
            }
            s+= word1[i];
            s+= word2[i];
        }
        return s;
    }
}
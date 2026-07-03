public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder s = new StringBuilder();
        var len = Math.Max(word1.Length, word2.Length);
        for (int i = 0; i < len; i++)
        {
            if(i == word1.Length)
            {
                s.Append(word2.Substring(i));
                return s.ToString();
            }
            else if (i == word2.Length)
            {
                s.Append(word1.Substring(i));
                return s.ToString();
            }
            s.Append(word1[i]);
            s.Append(word2[i]);
        }
        return s.ToString();
    }
}
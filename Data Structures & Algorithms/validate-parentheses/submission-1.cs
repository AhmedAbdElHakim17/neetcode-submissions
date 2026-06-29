public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        Dictionary<char,char> dic = new Dictionary<char,char>
        {
            {')','('},
            {']','['},
            {'}','{'}
        };
        foreach (var c in s)
        {
            if (dic.ContainsKey(c))
            {
                if (st.Count > 0 && st.Peek() == dic[c])
                    st.Pop();
                else
                    return false;
            }
            else
                st.Push(c);
        }
        return st.Count == 0;
    }
}
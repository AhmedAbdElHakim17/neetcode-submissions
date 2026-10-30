public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var st = new Stack<int>();
        var k = 0;
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            if(nums[i] != val)
                st.Push(nums[i]);
        }
        var c = st.Count;
        for(int i = 0; i < c; i++)
        {
            nums[i] = st.Peek();
            st.Pop();
            k++;
        }
        return k;
    }
}
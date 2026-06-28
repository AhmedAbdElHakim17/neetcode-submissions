public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Using IndexOf()
        // If I have 3 and used IndexOf (7-3 = 4), I'll get the other Index
        // then return int[nums[3],Index];

        // for(int i = 0; i < nums.Length; i++)
        // {
        //     int res = target - nums[i];
        //     var ind = Array.IndexOf(nums, res, i+1);
        //     if (ind != -1) // the value when no matching result
        //         return [i, ind];
        // }
        // return null;

        // Using HashMap
        // I've a Dictionary of int , int and get KeyValuePairs then returning 
        // the matching key of the result
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++)
        {
            // If matches return, else save the key-value pair
            int res = target - nums[i];
            if(dic.ContainsKey(res))
                return [dic[res], i];
            dic[nums[i]] = i;
        }
        return null;

    }
}

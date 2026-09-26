public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var dic = new Dictionary<int, int>();
        for(int i = 0; i < numbers.Length; i++)
        {
            var num = target - numbers[i];
            if(dic.ContainsKey(num))
                return [dic[num], i + 1];
            dic[numbers[i]] = i + 1;         
        }
        return [];
    }
}

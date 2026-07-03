public class Solution {
    public int MaxProfit(int[] prices) {
        int min = 101, max = 0;

        foreach (int price in prices)
        {
            if(min > price)
                min = price;
            else
                max = Math.Max(max, price - min) ;   
        }
        return max;
    }
}

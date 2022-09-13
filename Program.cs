namespace BuyAndSellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = {7,1,5,3,6,4};

            int result = calculateProfit(prices);
            Console.WriteLine("Profit is :" + result);
        }

        private static int calculateProfit(int[] prices)
        {
            int init = 0, max =0;

            for(int i =1; i < prices.Length; i++)
            {
                init += prices[i] - prices[i-1];

                if(init < 0 )
                    init = 0;
                if(init > max)
                    max = init;
                
            }
            return max;
        }
    }
}
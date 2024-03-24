public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int minEatingRate = 1, maxEatingRate = piles.Max(); 
        int minBanTotalPerHour = maxEatingRate;

        while(minEatingRate <= maxEatingRate){
            int midEatingRate = minEatingRate + (maxEatingRate - minEatingRate) / 2;  
            int calculatedMinHours = 0;

            foreach(int bananas in piles){
                calculatedMinHours += (int)Math.Ceiling((double)bananas / midEatingRate);
            }
            
            if(calculatedMinHours < 0) break;

            if(calculatedMinHours <= h){
                minBanTotalPerHour = Math.Min(midEatingRate, minBanTotalPerHour);
                maxEatingRate = midEatingRate -1;
            }else{
                minEatingRate = midEatingRate +1;
            }
        }
        return minBanTotalPerHour;
    }
}

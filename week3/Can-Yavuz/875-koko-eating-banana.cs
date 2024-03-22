public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var minEatingRate = 1; 
        var maxEatingRate = int.MinValue; 
        foreach (var pile in piles) {
            maxEatingRate = Math.Max(maxEatingRate, pile); 
        }
        var minBanTotalPerHour = maxEatingRate;

        while(minEatingRate <= maxEatingRate){
            var midEatingRate = (minEatingRate + maxEatingRate) / 2;  
            var calculatedMinHours = 0;

            foreach(var bananas in piles){
                calculatedMinHours += (int)Math.Ceiling((double)bananas / midEatingRate);
            }

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

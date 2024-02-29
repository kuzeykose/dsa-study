class Solution {
    public int carFleet(int target, int[] position, int[] speed) {
        int ans = 0;
        double[] arr = new double[target];
        for (int i = 0; i < position.length; i++){
            arr[position[i]]= (double)(target - position[i]) / speed[i];
        }
        double prev = 0.0;
        for (int i = target-1; i >=0 ; i--){
            double cur = arr[i];
            if (cur > prev){
                prev = cur;
                ans++;
            }
        }
        return ans;   
    }
}
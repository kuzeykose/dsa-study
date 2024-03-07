class Solution {
    public int carFleet(int target, int[] position, int[] speed) {
        double[] time = new double[target];
        for (int i = 0; i < position.length; i++) {
            int pos = position[i];
            time[pos] = (double) (target - pos) / speed[i];
        }
        double prev = 0.0;
        int res = 0;
        for (int i = target - 1; i >= 0; i--) {
            if (time[i] > prev) {
                res++;
                prev = time[i];
            }
        }
        return res;
    }
}
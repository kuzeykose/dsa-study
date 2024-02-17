class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        if (nums.length == 1) return new int[]{nums[0]};
        int[] ans = new int[k];
        HashMap<Integer,Integer> map = new HashMap<>();
        for (int num : nums) {
            map.put(num, map.getOrDefault(num, 0) + 1);
        }
        PriorityQueue<Integer> queue = new PriorityQueue<>(new Comparator<Integer>() {
            public int compare(Integer num1, Integer num2) {
                return map.get(num2) - map.get(num1);
            }
        });

        queue.addAll(map.keySet());

        for (int i = 0; i < k; i++) {
            ans[i] = queue.poll();
        }
        return ans;
    }
}

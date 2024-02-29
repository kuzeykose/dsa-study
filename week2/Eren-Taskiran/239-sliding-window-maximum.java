class Solution {
    public int[] maxSlidingWindow(int[] nums, int k) {
        int n = nums.length;
        if (k == 1) return nums;

        int[] ans = new int[n - k + 1];
        int index = 0;
        Deque<Integer> deque = new ArrayDeque<>();

        for (int i = 0; i < n; i++) {
            while (!deque.isEmpty() && deque.peek() < i - k + 1) {
                deque.poll();
            }

            while (!deque.isEmpty() && nums[i] >= nums[deque.peekLast()]) {
                deque.pollLast();
            }

            deque.offer(i);

            if (i >= k - 1) {
                ans[index++] = nums[deque.peek()];
            }
        }

        return ans;
    }
}

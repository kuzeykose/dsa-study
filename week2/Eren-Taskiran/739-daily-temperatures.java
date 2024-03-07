class Solution {
    public int[] dailyTemperatures(int[] temps) {
        int[] results = new int[temps.length];
        Stack<Pair<Integer, Integer>> stack = new Stack<>();

        for (int i = 0; i < temps.length; i++) {
            while (!stack.isEmpty() && temps[i] > stack.peek().getKey()) {
                Pair<Integer, Integer> curr = stack.pop();
                results[curr.getValue()] = i - curr.getValue();
            }
            stack.push(new Pair<>(temps[i], i));
        }
        return results;
    }
}
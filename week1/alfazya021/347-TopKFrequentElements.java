class Solution {
    public int[] topKFrequent(int[] nums, int k) {
        Integer constant = (int)Math.pow(10, 4);
        
        int[] map = new int[2 * constant + 3];
        
        HashSet<Integer> hset = new HashSet<>();
        
        for(int i: nums) {
            hset.add(i);
            map[i + constant]++;
        }
         
        PriorityQueue<Integer[]> queue = new PriorityQueue<>((a,b) -> a[0]-b[0]);
        
        for(Integer i: hset) {
            Integer[] array = {map[i + constant], i};
            queue.add(array);
            if(queue.size() > k) {
                queue.poll();
            }
        }
        
        int[] answer = new int[k];
        int j = 0;
        Integer[][] array = new Integer[k][2];
        
        for(Integer[] i: queue.toArray(array)) {
            answer[j] = i[1];
            j++;
        }
        
        return answer;
    }
}
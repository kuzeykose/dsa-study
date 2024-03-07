class Solution {
    public int evalRPN(String[] tokens) {
        Stack<Integer> numbers = new Stack();

        for (String e : tokens) {
            switch (e) {
                case "/": {
                    int i1 = numbers.pop();
                    int i2 = numbers.pop();
                    numbers.push(i2 / i1);
                    break;
                }
                case "+": {
                    int i1 = numbers.pop();
                    int i2 = numbers.pop();
                    numbers.push(i2 + i1);
                    break;
                }
                case "-": {
                    int i1 = numbers.pop();
                    int i2 = numbers.pop();
                    numbers.push(i2 - i1);
                    break;
                }
                case "*": {
                    int i1 = numbers.pop();
                    int i2 = numbers.pop();
                    numbers.push(i2 * i1);
                    break;
                }
                default: {
                    numbers.push(Integer.parseInt(e));
                }
            }
        }

        return numbers.pop();
    }
}
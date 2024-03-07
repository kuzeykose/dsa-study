import java.util.EmptyStackException;

public class MyStackImplementation {

    public static void main(String[] args) {
        String[] testCase1 = new String[] { "push", "push", "push", "pop" };
        Integer[] testCase1Values = new Integer[] { 2, 1, null };
        String testCase1Answer = "1,2";

        if (Test(testCase1, testCase1Values, testCase1Answer)) {
            System.out.println("Test case 1 - PASS");
        } else {
            System.out.println("Test case 1 - FAIL");
        }

        String[] testCase2 = new String[] { "push", "push", "push", "pop", "pop" };
        Integer[] testCase2Values = new Integer[] { 2, 1, null };
        String testCase2Answer = "2";

        if (Test(testCase2, testCase2Values, testCase2Answer)) {
            System.out.println("Test case 2 - PASS");
        } else {
            System.out.println("Test case 2 - FAIL");
        }
    }

    public static boolean Test(String[] methods, Integer[] values, String ans) {
        MyStack<Integer> mystack = new MyStack<>();

        for (int i = 0; i < methods.length; i++) {
            switch (methods[i]) {
                case "push":
                    mystack.push(values[i]);
                    break;
                case "pop":
                    mystack.pop();
                    break;
                case "peek":
                    mystack.peek();
                    break;
                case "isEmpty":
                    mystack.isEmpty();
                    break;
                default:
                    break;
            }
        }

        return ans.equals(mystack.toString());
    }
}

class Node<T> {
    T data;
    Node<T> next;

    Node(T data, Node<T> next) {
        this.data = data;
        this.next = next;
    }
}

class MyStack<T> {
    Node<T> head = null;

    public void push(T val) {
        if (val == null) {
            throw new IllegalArgumentException();
        }
        head = new Node<>(val, head);
    }

    public T pop() {
        if (head == null) {
            throw new EmptyStackException();
        }
        T data = peek();
        head = head.next;
        return data;
    }

    public T peek() {
        if (head == null) {
            return null;
        }
        return head.data;
    }

    public boolean isEmpty() {
        return head == null;
    }

    @Override
    public String toString() {
        Node<T> temp = head;

        StringBuilder sb = new StringBuilder();

        if (temp != null) {
            sb.append(temp.data.toString());
            temp = temp.next;
        }

        while (temp != null) {
            sb.append(",");
            sb.append(temp.data.toString());
            temp = temp.next;
        }

        return sb.toString();
    }
}
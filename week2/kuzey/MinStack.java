class Node {
    int data;
    int min;
    Node next;

    Node(int data, int min, Node next) {
        this.data = data;
        this.min = min;
        this.next = next;
    }
}

class MinStack {
    Node head;
    int size;

    public MinStack() {
        head = null;
        size = 0;
    }

    public void push(int val) {
        if (head == null) {
            head = new Node(val, val, null);
        } else {
            if (val < getMin()) {
                head = new Node(val, val, head);
            } else {
                head = new Node(val, getMin(), head);
            }
        }
    }

    public void pop() {
        head = head.next;
    }

    public int top() {
        return head.data;
    }

    public int getMin() {
        return head.min;
    }
}

public class Stack {
    private Node<Integer> head;
    private int size;

    public void push(int value){
        head = new Node<Integer>(value, head);
        size++;
    }

    public int pop(){
        if(isEmpty()){
            throw new IllegalStateException("Stack is empty");
        }
        int value=head.value;
        head=head.prev;
        size--;
        return value;
    }

    public int peek(){
        if(isEmpty()){
            throw new IllegalStateException("Stack is empty");
        }
        return head.value;
    }

    public int size(){
        return size;
    }

    public boolean isEmpty(){
        return size==0;
    }

    @Override
    public String toString(){
        StringBuilder sb = new StringBuilder();
        Node<Integer> current=head;

        if(current!=null){
            sb.append(current.value);
            current=current.prev;
        }

        while (current!=null){
            sb.append(" -> ");
            sb.append(current.value);
            current=current.prev;
        }

        return sb.toString();
    }
}
class Node<T>{
    public T value;
    public Node<T> prev;

    public Node(T value){
        this.value=value;
        this.prev=null;
    }
    public Node(T value,Node<T> prev){
        this.value=value;
        this.prev=prev;
    }
}
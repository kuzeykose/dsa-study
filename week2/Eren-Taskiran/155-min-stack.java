class MinStack {
    Node node;
    public MinStack() {
    }
    
    public void push(int val) {
       Node newnode = new Node(val,node);
       node = newnode;
    }
    
    public void pop() {
        node=node.prev;
    }
    
    public int top() {
        return node.value;
    }
    
    public int getMin() {
        return node.min;
    }
    class Node{
        int value;
        Node prev;
        int min;
        Node(int value, Node prev){
            this.value=value;
            this.prev=prev;
            if( prev!=null && value>prev.min ){
                this.min =prev.min;
            }else{
                this.min=value;
            }
        }
    }
}
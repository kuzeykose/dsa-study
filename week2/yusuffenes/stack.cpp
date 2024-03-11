//Tek bağlı doğrusal liste

template <typename T>
struct Node {
    T data;
    Node<T>* next;
};
template <typename T>
class LinkedList {
private:
    Node<T>* head;
    Node<T>* tail;

public:
    LinkedList() {
        head = nullptr;
        tail = nullptr;
    }
    void Add(T data) {
        Node<T>* newNode = new Node<T>{ data, nullptr };
        if (head == nullptr)
            head = tail = newNode;
        else {
            tail->next = newNode;
            tail = newNode;
        }
    }
    void Remove(T data) {
        Node<T>* current = head;
        Node<T>* previous = nullptr;
        while (current != nullptr) {
            if (current->data == data) {
                if (previous == nullptr)
                    head = current->next;
                else
                    previous->next = current->next;
                delete current;
                current = nullptr;
                return;
            }
            previous = current;
            current = current->next;
        }
    }
    bool Update(T oldData, T newData) {
        Node<T>* current = head;
        while (current != nullptr) {
            if (current->data == oldData) {
                current->data = newData;
                return true;
            }
            current = current->next;
        }
        return false;
    }
};

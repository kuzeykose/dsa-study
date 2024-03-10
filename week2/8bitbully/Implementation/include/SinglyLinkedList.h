#pragma once

#include <memory>
#include <stdexcept>

template <typename T> struct Node {
private:
  T element;

  std::shared_ptr<Node<T>> next;

public:
  Node(T val);

  Node(T val, std::shared_ptr<Node<T>>);

  T getElement();
  std::shared_ptr<Node<T>> getNext();

  void setNext(std::shared_ptr<Node<T>> n);
};

template <typename T> class SinglyLinkedList {
private:
  std::shared_ptr<Node<T>> head;

  std::shared_ptr<Node<T>> tail;

  int size;

public:
  SinglyLinkedList();

  int getSize() const;

  bool isEmpty() const;

  T first() const;

  T last() const;

  void addFirst(T e);

  void addLast(T e);

  T removeFirst();
};

/*         Node           */

template <typename T> Node<T>::Node(T val) : element(val), next(nullptr) {}

template <typename T>
Node<T>::Node(T val, std::shared_ptr<Node<T>> n) : element(val), next(n) {}

template <typename T> T Node<T>::getElement() { return element; }

template <typename T> std::shared_ptr<Node<T>> Node<T>::getNext() {
  return next;
}

template <typename T> void Node<T>::setNext(std::shared_ptr<Node<T>> n) {
  next = n;
}

/*     Linked List       */

template <typename T>
SinglyLinkedList<T>::SinglyLinkedList()
    : head(nullptr), tail(nullptr), size(0) {}

// access methods
template <typename T> int SinglyLinkedList<T>::getSize() const { return size; }

template <typename T> bool SinglyLinkedList<T>::isEmpty() const {
  return size == 0;
}

template <typename T> T SinglyLinkedList<T>::first() const {
  if (isEmpty()) {
    std::logic_error("List is empty");
  }

  return head->getElement();
}

template <typename T> T SinglyLinkedList<T>::last() const {
  if (isEmpty()) {
    std::logic_error("List is empty");
  }

  return tail->getElement();
}

// update methods
template <typename T> void SinglyLinkedList<T>::addFirst(T e) {
  head = std::make_shared<Node<T>>(e, head);

  if (size == 0) {
    tail = head;
  }
  size++;
}

template <typename T> void SinglyLinkedList<T>::addLast(T e) {
  std::shared_ptr<Node<T>> newest = std::make_shared<Node<T>>(e, nullptr);

  if (isEmpty()) {
    head = newest;
  } else {
    tail->setNext(newest);
  }

  tail = newest;
  size++;
}

template <typename T> T SinglyLinkedList<T>::removeFirst() {
  if (isEmpty()) {
    std::logic_error("List is empty");
  }
  T answer = head->getElement();
  head = head->getNext();
  size--;

  if (size == 0) {
    tail = nullptr;
  }

  return answer;
}

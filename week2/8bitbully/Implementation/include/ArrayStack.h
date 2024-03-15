#pragma once

#include "Stack.h"

#include <memory>
#include <stdexcept>
#include <vector>

template <typename E> class ArrayStack : public Stack<E> {
private:
  int CAPACITY;
  std::shared_ptr<E[]> data;
  int t;

public:
  ArrayStack();

  ArrayStack(int capacity);

  int size() const;

  bool isEmpty() const;

  void push(const E e);

  const E top() const;

  E pop();
};

template <typename E>
ArrayStack<E>::ArrayStack() : CAPACITY(1000), data(new E[CAPACITY]), t(-1) {}

template <typename E>
ArrayStack<E>::ArrayStack(int capacity)
    : CAPACITY(capacity), data(new E[CAPACITY]), t(-1) {}

template <typename E> int ArrayStack<E>::size() const { return (t + 1); }

template <typename E> bool ArrayStack<E>::isEmpty() const { return (t == -1); }

template <typename E> void ArrayStack<E>::push(const E e) {
  if (size() == CAPACITY)
    throw std::runtime_error("Stack is full");
  data[++t] = e;
}

template <typename E> const E ArrayStack<E>::top() const {
  if (isEmpty())
    throw std::runtime_error("Stack is empty");
  return data[t];
}

template <typename E> E ArrayStack<E>::pop() {
  if (isEmpty())
    throw std::runtime_error("Stack is empty");
  E answer = data[t];
  data[t] = E(); // dereference to help garbage collection
  t--;
  return answer;
}

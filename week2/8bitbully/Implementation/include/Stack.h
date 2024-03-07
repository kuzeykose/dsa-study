#pragma once

template <typename E> class Stack {
public:
  virtual int size() const = 0;
  virtual bool isEmpty() const = 0;
  virtual void push(const E e) = 0;
  virtual const E top() const = 0;
  virtual E pop() = 0;
};

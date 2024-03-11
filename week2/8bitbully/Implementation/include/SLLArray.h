#pragma once

#include "SinglyLinkedList.h"
#include "Stack.h"
#include <algorithm>
#include <system_error>

template <typename E> class SLLArray : public Stack<E> {
private:
  SinglyLinkedList<E> list;

public:
  SLLArray();

  int size() const;

  bool isEmpty() const;

  void push(const E element);

  const E top() const;

  E pop();
};

template <typename E> SLLArray<E>::SLLArray() : list(SinglyLinkedList<E>()) {}

template <typename E> int SLLArray<E>::size() const { return list.getSize(); }

template <typename E> bool SLLArray<E>::isEmpty() const {
  return list.isEmpty();
}

template <typename E> void SLLArray<E>::push(const E element) {
  list.addFirst(element);
}

template <typename E> const E SLLArray<E>::top() const { return list.first(); }

template <typename E> E SLLArray<E>::pop() { return list.first(); }

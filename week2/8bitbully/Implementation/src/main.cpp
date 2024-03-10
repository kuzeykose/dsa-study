#include "ArrayStack.h"
#include "SLLArray.h"
#include "SinglyLinkedList.h"

#include <iostream>
#include <ostream>

int main() {

  {
    SinglyLinkedList<int> intList;

    intList.addFirst(3);
    std::cout << intList.first() << ' ' << intList.last() << std::endl;
    intList.addFirst(12);
    std::cout << intList.first() << ' ' << intList.last() << std::endl;

    std::cout << intList.getSize() << std::endl;

    intList.addLast(44);
    std::cout << intList.first() << ' ' << intList.last() << std::endl;
    intList.addLast(21);
    std::cout << intList.first() << ' ' << intList.last() << std::endl;
    intList.addLast(51);

    std::cout << intList.getSize() << std::endl;

    intList.removeFirst();
    intList.removeFirst();
    std::cout << intList.first() << ' ' << intList.last() << std::endl;
    intList.removeFirst();
    std::cout << intList.getSize() << std::endl;
  }

  {
    ArrayStack<int> stack;
    stack.push(10);
    stack.push(20);
    stack.push(30);

    std::cout << stack.top() << std::endl;
    int e = stack.pop();
    std::cout << e << std::endl;
    std::cout << stack.top() << std::endl;
  }

  {
    SLLArray<char> sllStack;
    sllStack.push('e');
    sllStack.push('b');
    sllStack.push('c');

    std::cout << sllStack.top() << std::endl;
    char e = sllStack.pop();
    std::cout << e << std::endl;
    std::cout << sllStack.top() << std::endl;
  }

  return 0;
}

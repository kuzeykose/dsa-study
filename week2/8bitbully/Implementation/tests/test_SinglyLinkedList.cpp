
#include "../include/SinglyLinkedList.h"
#include "gtest/gtest.h"

// Node class tests
TEST(NodeTest, Constructor) {
  Node<int> node(17);
  EXPECT_EQ(node.getElement(), 17);
}

TEST(NodeTest, ConstructorWithNext) {
  Node<int> nextNode(999);
  Node<int> node(765, std::make_shared<Node<int>>(nextNode));
  EXPECT_EQ(node.getNext()->getElement(), 999);
}

TEST(NodeTest, SetNext) {
  Node<int> node(61);
  Node<int> nextNode(35);
  node.setNext(std::make_shared<Node<int>>(nextNode));
  EXPECT_EQ(node.getNext()->getElement(), 35);
}

// SinglyLinkedList class tests
TEST(SinglyLinkedListTest, Constructor) {
  SinglyLinkedList<int> list;
  EXPECT_TRUE(list.isEmpty());
  EXPECT_EQ(list.getSize(), 0);
}

TEST(SinglyLinkedListTest, AddFirst) {
  SinglyLinkedList<int> list;
  list.addFirst(111);
  EXPECT_EQ(list.first(), 111);
  EXPECT_EQ(list.last(), 111);
  EXPECT_EQ(list.getSize(), 1);
}

TEST(SinglyLinkedListTest, AddLast) {
  SinglyLinkedList<int> list;
  list.addLast(428);
  EXPECT_EQ(list.first(), 428);
  EXPECT_EQ(list.last(), 428);
  EXPECT_EQ(list.getSize(), 1);
}

TEST(SinglyLinkedListTest, AddFirstAndLast) {
  SinglyLinkedList<int> list;
  list.addFirst(777);
  list.addLast(666);
  EXPECT_EQ(list.first(), 777);
  EXPECT_EQ(list.last(), 666);
  EXPECT_EQ(list.getSize(), 2);
}

TEST(SinglyLinkedListTest, RemoveFirst) {
  SinglyLinkedList<int> list;
  list.addFirst(12);
  int removed = list.removeFirst();
  EXPECT_EQ(removed, 12);
  EXPECT_TRUE(list.isEmpty());
  EXPECT_EQ(list.getSize(), 0);
}

TEST(SinglyLinkedListTest, RemoveFirstFromEmptyList) {
  SinglyLinkedList<int> list;
  EXPECT_THROW(list.removeFirst(), std::logic_error);
}

TEST(SinglyLinkedListTest, FirstOnEmptyList) {
  SinglyLinkedList<int> list;
  EXPECT_THROW(list.first(), std::logic_error);
}

TEST(SinglyLinkedListTest, LastOnEmptyList) {
  SinglyLinkedList<int> list;
  EXPECT_THROW(list.last(), std::logic_error);
}

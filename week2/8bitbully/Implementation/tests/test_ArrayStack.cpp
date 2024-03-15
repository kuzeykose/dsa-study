#include "../include/ArrayStack.h"
#include "gtest/gtest.h"

TEST(ArrayStackTest, DefaultConstructorTest) {
  ArrayStack<char> stack;
  EXPECT_EQ(stack.size(), 0);
  EXPECT_TRUE(stack.isEmpty());
}

TEST(ArrayStackTest, ConstructorWithCapacityTest) {
  ArrayStack<char> stack(5);
  EXPECT_EQ(stack.size(), 0);
  EXPECT_TRUE(stack.isEmpty());
}

TEST(ArrayStackTest, PushAndTopTest) {
  ArrayStack<char> stack;
  stack.push('b');
  EXPECT_EQ(stack.top(), 'b');
  EXPECT_EQ(stack.size(), 1);
  EXPECT_FALSE(stack.isEmpty());
}

TEST(ArrayStackTest, PopTest) {
  ArrayStack<char> stack;
  stack.push('d');
  EXPECT_EQ(stack.pop(), 'd');
  EXPECT_EQ(stack.size(), 0);
  EXPECT_TRUE(stack.isEmpty());
}

TEST(ArrayStackTest, PopFromEmptyStackTest) {
  ArrayStack<char> stack;
  EXPECT_THROW(stack.pop(), std::runtime_error);
}

TEST(ArrayStackTest, TopFromEmptyStackTest) {
  ArrayStack<double> stack;
  EXPECT_THROW(stack.top(), std::runtime_error);
}

TEST(ArrayStackTest, PushToFullStackTest) {
  ArrayStack<char> stack(1);
  stack.push('p');
  EXPECT_THROW(stack.push('l'), std::runtime_error);
}

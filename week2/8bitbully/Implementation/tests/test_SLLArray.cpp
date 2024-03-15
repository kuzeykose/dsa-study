#include "../include/SLLArray.h"
#include "gtest/gtest.h"

TEST(SLLArrayTest, IntTest) {
  SLLArray<int> stack;
  stack.push(12);
  EXPECT_EQ(stack.top(), 12);
  EXPECT_EQ(stack.size(), 1);
  EXPECT_FALSE(stack.isEmpty());
}

TEST(SLLArrayTest, StringTest) {
  SLLArray<std::string> stack;
  stack.push("burasi");
  stack.push("bizim");
  EXPECT_EQ(stack.top(), "bizim");
  EXPECT_EQ(stack.size(), 2);
  EXPECT_FALSE(stack.isEmpty());
}

TEST(SLLArrayTest, CharTest) {
  SLLArray<char> stack;
  stack.push('a');
  stack.push('b');
  EXPECT_EQ(stack.top(), 'b');
  EXPECT_EQ(stack.size(), 2);
  EXPECT_FALSE(stack.isEmpty());
}

TEST(SLLArrayTest, PopTest) {
  SLLArray<int> stack;
  stack.push(444);
  EXPECT_EQ(stack.pop(), 444);
  EXPECT_EQ(stack.size(), 0);
  EXPECT_TRUE(stack.isEmpty());
}

TEST(SLLArrayTest, PopFromEmptyStackTest) {
  SLLArray<int> stack;
  EXPECT_THROW(stack.pop(), std::logic_error);
}

TEST(SLLArrayTest, TopFromEmptyStackTest) {
  SLLArray<int> stack;
  EXPECT_THROW(stack.top(), std::logic_error);
}

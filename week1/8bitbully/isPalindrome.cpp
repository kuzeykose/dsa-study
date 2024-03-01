// 125. Valid Palindrome
#include <string>
using namespace std;

bool isPalindrome(string s) {
  string result = "";

  for (char ch : s) {
    if (isalnum(ch)) {
      result += tolower(ch);
    }
  }

  const int length = result.size();

  for (int i = 0; i < length / 2; i++) {
    if (result[i] != result[length - 1 - i]) {
      return false;
    }
  }

  return true;
}

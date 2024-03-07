// 20. Valid Parentheses
#include <functional>
#include <stack>
#include <string>
#include <unordered_map>

class Solution {
private:
  std::unordered_map<char, char> keys{{')', '('}, {'}', '{'}, {']', '['}};
  std::stack<std::function<bool(char &)>> parentheses;

public:
  auto posFunction(char c) {

    return [c, this](char &ch) {
      parentheses.pop();
      return c == keys[ch];
    };
  }

  bool isValid(std::string s) {

    for (char &c : s) {

      if (!keys.count(c))
        parentheses.push(posFunction(c));

      else if (parentheses.empty() || !parentheses.top()(c))
        return false;
    }

    return parentheses.empty();
  }
};

/**
 * @param {string[]} tokens
 * @return {number}
 */

var evalRPN = function (tokens) {
    let stack = [];
  
    for (let i = 0; i < tokens.length; i++) {
      if (
        tokens[i] === "+" ||
        tokens[i] === "-" ||
        tokens[i] === "*" ||
        tokens[i] === "/"
      ) {
        const firstEl = stack.pop();
        const secondEl = stack.pop();
        const result = calculate(secondEl,firstEl, tokens[i]);
        stack.push(result);
      } else {
        stack.push(Number(tokens[i]));
      }
    }
    return stack.pop();
  };
  
  var calculate = (num1, num2, token) => {
    if (token === "+") return Number(num1) + Number(num2);
    if (token === "-") return Number(num1) - Number(num2);
    if (token === "*") return Number(num1) * Number(num2);
    if (token === "/") return num1 / num2 >= 0 ? Math.floor(num1 / num2) : Math.ceil(num1 / num2);
  };
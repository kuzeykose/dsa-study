/**
 * @param {number} n
 * @return {string[]}
 */
var generateParenthesis = function (n) {
    const array = [];
  
    const buildParenthesis = (openCount, closeCount, str, n, arr) => {
      if (str.length === n * 2) {
        arr.push(str);
        return;
      }
      if (openCount)
        buildParenthesis(openCount - 1, closeCount, str + "(", n, arr);
      if (closeCount > openCount)
        buildParenthesis(openCount, closeCount - 1, str + ")", n, arr);
    };
    buildParenthesis(n, n, "", n, array);
    return array;
  };
  
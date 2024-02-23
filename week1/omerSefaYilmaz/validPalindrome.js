/**
 * @param {string} s
 * @return {boolean}
 */
var isPalindrome = function (s) {
    let right = s.length - 1;
    let left = 0;
  
    while (left < right) {
      while (left < right && !isAlphaNumeric(s.charCodeAt(left))) {
        left++;
      }
  
      while (left < right && !isAlphaNumeric(s.charCodeAt(right))) {
        right--;
      }
  
      if (s[left].toLowerCase() !== s[right].toLowerCase()) {
        return false;
      }
      left++;
      right--;
    }
  
    return true;
  };
  
  const isAlphaNumeric = (charCode) => {
    return (
      (charCode >= 48 && charCode <= 57) ||
      (charCode >= 65 && charCode <= 90) ||
      (charCode >= 97 && charCode <= 122)
    );
  };
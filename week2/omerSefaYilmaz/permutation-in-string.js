/**
 * @param {string} s1
 * @param {string} s2
 * @return {boolean}
 */
var checkInclusion = function (s1, s2) {
    let s1Key = getKey(s1);
  
    for (let j = 0; j < s2.length; j++) {
      const windowSize = s1.length;
      let s2Key = getKey(s2.slice(j, j + windowSize));
      if(s1Key === s2Key) return true
    }
    return false
  };
  
  var getKey = (str) => {
    let strCharCount = new Array(26).fill(0);
    for (let i = 0; i < str.length; i++) {
      strCharCount[str.charCodeAt(i) - "a".charCodeAt(0)]++;
    }
    let key = strCharCount.join("#");
    return key;
  };
  
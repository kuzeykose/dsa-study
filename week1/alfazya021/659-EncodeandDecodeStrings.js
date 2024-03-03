var encode = (strs) => {
  delimiter = "/";
  let answer = "";

  for (let i = 0; i < strs.length; i++) {
    answer += strs[i];

    if (i < strs.length - 1) {
      answer += strs[i];
    }
  }

  return answer;
};

var decode = (str) => {
  delimiter = "/";
  let answer = [];
  let tmp = "";

  for (let i = 0; i < str.length + 1; i++) {
    if (str[i] === undefined || str[i] == "/") {
      answer.push(tmp);
      tmp = "";
      continue;
    }
    
    tmp += str[i];
  }

  return answer;
};

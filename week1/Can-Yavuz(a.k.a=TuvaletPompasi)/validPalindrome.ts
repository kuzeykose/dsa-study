function isPalindrome(s: string): boolean {
    const cleanString: string = s.replace(/[^A-Za-z0-9]/g, '').toLowerCase();
     const reversedString: string = cleanString.split('').reverse().join('');
     return cleanString === reversedString;
 };
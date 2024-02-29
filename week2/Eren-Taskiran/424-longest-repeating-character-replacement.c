int characterReplacement(char* s, int k) {
    int map[26] = {0};
    int max = 0;
    int left = 0;
    int ans = 0;
    int r;
    
    for (r = 0; s[r] != '\0'; r++) {
        map[s[r] - 'A']++;
        if (max < map[s[r] - 'A']) {
            max = map[s[r] - 'A'];
        }
        if (r - left + 1 - max > k) {
            map[s[left] - 'A']--;
            left++;
        }
        if (ans < r - left + 1) {
            ans = r - left + 1;
        }
    }
    return ans;
}
int maxProfit(int* prices, int pricesSize) {
    int min=prices[0];
    int potentialProfit=0;
    int maxProfit=0;
    int i;
    for(i = 0; i<pricesSize; i++){
        if(min>prices[i]) min=prices[i];
        potentialProfit=prices[i]-min;
        if(potentialProfit>maxProfit) maxProfit=potentialProfit;
    }
    return maxProfit;
}

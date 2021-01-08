function reduceFuncParams(currencyFormatter) {
    let separator = ",";
    let symbol = "$";
    let symbolFirst = true;
    
    let dollarFormatter = value => currencyFormatter(separator, symbol, symbolFirst, value);
    return dollarFormatter;
}
function solution(inputNumber){
    let number = inputNumber;

    return function(num){
        let result = number +=num
        number = inputNumber;
        return result;
    }
}
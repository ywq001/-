//构建一个函数has9(number) ，可以判断number中是否带有数字9；
/*
 * has9(8) => false
 * has9(9) => true
 * has9(69) =>true
 * has9(91) =>true
 * has9(-9.9) =>false
 * has9(909) => true
 * has9(9月9) =>false
 */
function has9(number) {
    return hasX(number, 9);
}

function has8(number) {
    return hasX(number, 8);
}

function has6(number) {
    return hasX(number, 6);
}



function hasX(number, x) {
    return String(number).indexOf(x) >= 0;
}

//使用上述函数，找出10000以内有多少个数字包含：9或者8或者6。
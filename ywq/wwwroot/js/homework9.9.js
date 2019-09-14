//使用“模拟名称空间”技术，构建一个函数函数yz.fei.get986(number)；
//在yz.fei.get986(number)中包含不带参数的函数has9() / has8() / has6() ；
//让get986()通过调用has9()/has8()/has6()，能找出number以内有多少个数字包含：9或者8或6。
//var global = {};
//global.yz = {};
//global.yz.fei = {};
//global.yz.fei.get986 = function () { };
//global.yz.fei.get986 = function (number) {
//    var result = 0;
//    for (var i = 0; i < number + 1; i++) {
//        if (has9(i) || has8(i) || has6(i)) {
//            result++;
//        } else {
//            //什么都不做
//        }
//    }
//    console.log(result);
//};


//var get986 = function () {
//    var result = 0;
//    for (var i = 0; i < number + 1; i++) {
//        if (has9() || has8() || has6()) {
//            result++;
//        } else {
//            //什么都不做
//        }
//    }
    
//    function has9() {
//        return hasX(i, 9);
//    }
//    function has8() {
//        return hasX(i, 9);
//    }
//    function has6() {
//        return hasX(i, 6);
//    }
//    console.log(result);
//};





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
//function has9(number) {
//    return hasX(number, 9);
//}

//function has8(number) {
//    return hasX(number, 8);
//}

//function has6(number) {
//    return hasX(number, 6);
//}



//function hasX(number, x) {
//    if (typeof (number) === 0 && number > 0 && String(number)[1] != ".") {
//        var parameter = String(number);
//        var find = String(x);
//        return parameter.indexOf(find) >= 0;
//    } else {
//        console.log("请输入正整数");
//    }
    
//}

//使用上述函数，找出10000以内有多少个数字包含：9或者8或者6。
/*测试
 * 输入has（20）=>6
 * 输入has（14）=>3
 * 输入has（18）=>5
*/

//function has(number) {
//    var result = 0;
//    for (var i = 0; i < number + 1; i++) {
//        if (has9(i) || has8(i) || has6(i)) {
//            result++;
//        } else {
//            //什么都不做
//        }
//    }
//    console.log(result);
//}
//has(20);
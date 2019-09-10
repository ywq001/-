//将之前“找出素数”的代码封装成一个函数findPrime(max)，可以打印出max以内的所有素数。
//function findPrime(max) {
//    for (var x = 2; x < max; x++) {
//        for (var i = 2; i < x; i++) {
//            if (x % i === 0) {
//                //console.log(x + '不是素数');
//                break;
//            }
//            else {
//                if (i === x - 1) {
//                    console.log(x + '是素数');
//                }
//            }
//        }
//    }

//}


//执行设计参数，将之前“累加求和”的代码封装成一个函数Sum() ，可以计算任意起始位置、任意步长（如：1, 3, 5……或者0, 5, 10, 15……）的等差数列之和。
//var sum = function (i, j, k) {
//    var l = 0;
//    while (i < k) {
//        i = i + j;
//        l = l + i;
//    }
//    console.log(l);

//}
//sum(0, 8, 32);



//封装一个函数，建立一个函数getMaxNumber()，可以接受任意多各种类型（整数、小数、正数、负数、字符串、布尔值等）的参数，并找出里面最大的数（忽略其他类型）



//var getMaxNumber = function () {
//    var max = -Infinity;
//    for (var i = 0; i < arguments.length; i++) {
//        if (typeof arguments[i]=='number'&& arguments[i] > max) {
//            max = arguments[i];
//        }
//    }
//    console.log(max);
//    return max;
//}
//getMaxNumber(85, 69, 87, -85, 35.6, 'ture');


//封装一个函数Swap(arr, i, j) ，可以交换数组arr里下标 i 和 j 的值
//function Swap(arr, i, j) {
//    a = arr[i];
//    arr[i] = arr[j];
//    arr[j] = a;
//    console.log(arr);
//}







//利用上面的Swap()函数，将“冒泡排序”封装成函数bubbleSort()
//function bubbleSortb(flame) {
//    for (var i = 0; i < flame.length; i++) {
//        for (var j = 0; j < flame.length; j++) {
//            if (flame[j] > flame[j + 1]) {
//                
//                Swap(flame, j, j + 1);
//            }
//        }
//    }
//    console.log(flame);
//}
//bubbleSortb([85, 56, 98, 75, 63, 74]);


//将源栈同学姓名 / 昵称装入数组，再根据该数组输出共有多少同学
//var students = new Array();
//var students = ["彭志强", "于维谦", "兴龙泰", "薛明林", "陈百万", "杨进文", "王新", "陈小丁", "陈晨"];
//var math = students.unshift("小余老师");
//var math = students.push('大飞哥');
//console.log(students, students.length);

//在上述数组头部加上小鱼老师，末尾加上大飞哥



//删除一个数组里面重复的元素
//function element(method) {
//var arr = [];
//for (var i = 0; i < method.length; i++) {
//if (arr.indexOf(method[i]) == -1) {
//arr.push(method[i])
//        }
//    }

//    console.log(arr);
//}
//element([5, 6, 8, 5, 6, 8]);






//使用JavaScript内置字符串函数，处理 “‘源栈’：飞哥小班教学，线下免费收看” ：“飞哥”改成“大神”，“线下”改成“线上”。
//var str = "'源栈':飞哥小班教学，线下免费收看"
//str = (str.replace("飞哥", "大神").replace("线下", "线上"));


//将数组['why', 'gIT', 'vs2019', 'community', 'VERSION']规范化，所有字符串：
//首字母大写开头，其他字母小写
//截去超过6个字符的部分，如'community'将变成'Commun'

//function early(sept) {
//    var arr = [];
//    for (var i = 0; i < arr.length; i++) {
//        arr[i] = sept[i].toLowerCase().slice(0, 6);
//        arr[i] = arr[i][0].toUpperCase() + arr[i].substring(1, 6);
//    }

//    return arr;
//}
//var sept = ['why', 'gIT', 'vs2019', 'community', 'VERSION'];
//var result = early(sept);





//创建一个函数getRandomArray(length, max) ，能返回一个长度不大于length，每个元素值不大于max的随机整数数组。
//function getRandomArray(length, max) {
//    var getup = [];
//    for (var i = 0; i <length - 1; i++) {
//        getup[i] = Math.floor(Math.random() * max);
//        getup.push[i];
//    }
//    console.log(getup);
//}
//getRandomArray(8, 35);



//不使用JavaScript内置函数，将一个字符串顺序颠倒，比如：'hello,yuanzhan' 变成 'nahznauy,olleh'。
//function order(call) {
//    var called = "";
//    for (var i = call.length - 1; i >= 0; i--) {
//        called += call[i];
//    }
//    return called;
//}
//console.log(order("hello,yuanzhan"));



//统计出这段文字中有多少个单词：
//There are two ways to create a RegExp object:
//a literal notation and a constructor.To indicate strings,
//    the parameters to the literal notation do not 
//    use quotation marks while the parameters to
//the constructor function do use quotation - marks.So 
//the following expressions create the same
//regular expression
//var whiteList="abcdefghijklmnopqrstuvwxyz"
//function brid(content) {
//    var Max = content.toLowerCase();
//    var counter = 1;
//    for (var i = 0; i < Max.length; i++) {
//        var current = whiteList.indexOf(Max[i]);
//        var next = whiteList.indexOf(Max[i + 1]);
//        if (current < 0 && next >= 0) {
//            counter++;
//        }
//    }
//    return counter;
//}
//console.log(brid("the parameters to the literal notation do not"));



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

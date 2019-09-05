//将之前“找出素数”的代码封装成一个函数findPrime(max)，可以打印出max以内的所有素数。
function findPrime(max) {
    for (var x = 2; x < max; x++) {
        for (var i = 2; i < x; i++) {
            if (x % i === 0) {
                //console.log(x + '不是素数');
                break;
            }
            else {
                if (i === x - 1) {
                    var result = console.log(x + '是素数');
                }
            }
        }
    }
    return result;
}
//执行设计参数，将之前“累加求和”的代码封装成一个函数Sum() ，可以计算任意起始位置、任意步长（如：1, 3, 5……或者0, 5, 10, 15……）的等差数列之和。
var sum = function (x) {
    var j = 0, i = 0;
    while (j < x) {
        j = j + 5;
        i = i + j;
    }
    console.log(i);
}
//封装一个函数，建立一个函数getMaxNumber()，可以接受任意多各种类型（整数、小数、正数、负数、字符串、布尔值等）的参数，并找出里面最大的数（忽略其他类型）



var getMaxNumber = function(){
    var max = -Infinity;
    for (var i = 0; i < arguments.length; i++) {
        if (arguments[i] > max) {
            max = arguments[i];
        }
    }
    console.log(max);
    return max;
} 


//封装一个函数Swap(arr, i, j) ，可以交换数组arr里下标 i 和 j 的值
function Swap() {
    var arr = Array;

}


//利用上面的Swap()函数，将“冒泡排序”封装成函数bubbleSort()




//将源栈同学姓名 / 昵称装入数组，再根据该数组输出共有多少同学
var studens = new Array();
var students = ["彭志强", "于维谦", "兴龙泰", "薛明林", "陈百万", "杨进文", "王新", "陈小丁", "陈晨"];
var math= students.unshift("小余老师");
console.log(studens, studens.length);

//在上述数组头部加上小鱼老师，末尾加上大飞哥


//在函数student()中声明了函数域变量name、age和female，使用闭包机制，将其暴露到函数外部

//function student() {
//    var name = '于维谦', age = 22;
//    var obj = { name, age };
//    return function () {
//        return obj;
//    };
//}

//解释以下代码运行结果：（ condition ? <statement when true> : <statement when false>）


//改动以下代码，让其输出如图所示，并说明理由。

//原代码
//function buildList(list) {
//    var result = [];
//    for (vari = 0; i < list.length; i++) {
//        result.push(function () {
//            console.log('item' + i + ': ' + list[i])
//        });
//    }
//    return result;
//}

//(function () {
//    var fnlist = buildList([1, 2, 3]);
//    for (var i = 0; i < fnlist.length; i++) {
//        fnlist[i]();
//    }
//})();
//改动后代码
function buildList(list) {
    var result = [];
    for (let i = 0; i < list.length; i++) {
        result.push(function () {
            console.log('item' + i + ': ' + list[i])
        });
    }
    return result;
}

(function () {
    var fnlist = buildList([1, 2, 3]);
    for (var i = 0; i < fnlist.length; i++) {
        fnlist[i]();
    }
})();
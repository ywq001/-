﻿
//实现铃铛（没有学bootstrap的同学用文字代替）闪烁效果
function changeColor() {
    var star = document.getElementById('flicker');
    if (star.style.color === 'red') {
        star.style.color = 'green';
    } else {
        star.style.color = 'red';
    }
}
setInterval(changeColor, 1000);

//模拟求助首页，并：

//统计有多少个悬赏大于1的求助
var joy = document.getElementsByClassName('beauty');
var counter = 0;
for (var i = 0; i < joy.length; i++) {
    if (+joy[i].innerText > 1) {
        counter++;
    } else {
        //no
    }
}
alert(counter);
//将状态为“协助中”的求助背景改成灰黑色
function help() {
    var assist = document.getElementsByClassName('idcard');
    for (var i = 0; i < assist.length; i++) {
        if (assist[i].innerText === '协助中') {
            assist[i].style.backgroundColor = '#33333378';
        } else {
            //跳过
        }
    }
}
help();   

//写一个函数，可以统计某个求助使用了多少关键字
function keyWord() {
    var fields = document.getElementsByClassName('gotta');
    for (var i = 0; i < fields.length; i++) {
        console.log(fields[0].getElementsByTagName('a').length);
    }
    
}
keyWord();
//如果总结数为0，将其从DOM树中删除

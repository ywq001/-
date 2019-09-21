
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
function removeChild() {
    var summarize = document.querySelectorAll("[ywq-summarize]");
    for (var j = 0; j < summarize.length; j++) {
        var career = summarize[j].getElementsByClassName('bear');
        for (var i = 0; i < career.length; i++) {
            if (career[i].getElementsByTagName('span')[2].innerText === '0') {
                summarize[j].removeChild(summarize[j].childNodes[5]);
            } else {
                //跳过
            }
        }
    }

}
removeChild();

//参考用户注册页面，创建一下函数：

//显示密码的长度,在控制台显示



console.log(document.querySelector("[ywq-password]").length)

//如果密码和确认密码不一致，弹出提示
var password = document.querySelector("[ywq-password]");
var confirmPassword = document.querySelector("[ywq-verify-password]");
if (password === confirmPassword) {
    //继续
} else {
    alert("确认密码与密码不一致")；
}
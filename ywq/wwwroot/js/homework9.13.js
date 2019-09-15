
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
//将状态为“协助中”的求助背景改成灰黑色
//写一个函数，可以统计某个求助使用了多少关键字
//如果总结数为0，将其从DOM树中删除

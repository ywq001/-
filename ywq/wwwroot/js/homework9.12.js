//使用setTimeout() （不是setInterval() ）实现每隔1秒钟依次显示：第n周，源栈同学random人。（n逐次递增，random随机）
//测试结果：每隔一秒显示，第n周，n逐次递加，直到第10周停止，上课人数小于20，不等于0.
//var counter = 1;
//function lesson() {
//    if (counter < 10) {
//        setTimeout(function () {
//            console.log("第" + counter + "周,源栈同学" +
//                Math.ceil(Math.random() * 20)+ "人");
//            counter++;
//            lesson();
//        },1000);
//    } else {
//        //什么都不做
//    };
//};
//lesson();
//Math.ceil();


//完成猜数字的游戏：
//弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
//浏览器生成一个不大于1000的随机正整数；
//用户输入猜测；
//如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
//只用了不到6次就猜到，弹出：碉堡了！
//只用了不到8次就猜到，弹出：666！
//用了8 - 10次猜到，弹出：猜到了。
//用了10次都还没猜对，弹出：^ (*￣(oo) ￣)^

var game = Math.ceil(Math.random() * 1000)
if (confirm(`完成猜数字的游戏：
弹出游戏玩法说明，等待用户点击“确认”，开始游戏；
浏览器生成一个不大于1000的随机正整数；
用户输入猜测；
如果用户没有猜对，浏览器比较后告知结果：“大了”或者“小了”。如果用户：
只用了不到6次就猜到，弹出：碉堡了！
只用了不到8次就猜到，弹出：666！
用了8-10次猜到，弹出：猜到了。
用了10次都还没猜对，弹出：^(*￣(oo)￣)^`)) {
    bingoGame();
} else {
    //什么都不做
}

function bingoGame() {
    for (var i = 0; i < 10; i++) {
        var word = prompt()

        if (!word) {
            break;
            return false;
        }
        if (!isNaN(word) && word > 0 && word.indexOf(",") == -1) {
            if (word = game) {
                if (i < 6) {
                    alert("碉堡了!")
                } else {
                    if (i < 8) {
                        alert("666!")
                    } else {
                        alert("猜到了.")
                    }
                }
                break;
            } else {
                if (i == 9) {
                    alert("^(*￣(oo)￣)^`")
                }
            }
            if (word < game) {
                alert("小了")
            } else {
                alert("大了")
            }
        } else {
            alert("请输入正整数")
        }
    }
}


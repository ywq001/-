//2.已有如下代码：
var sname = "飞哥";
var a = {
    sname: '老程',
    fn: function () {
        console.log(this.sname);
    }
}
//请用不同的方式调用fn()函数，能分别打印出‘飞哥’和‘老程’
a.fn.call();
var bname = { sname: "飞哥" };
a.fn.apply(bname);
a.fn();

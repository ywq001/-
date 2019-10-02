//JSON生成和解析：
//按自己的情况，生成一个JSON字符串，包括真实姓名、QQ昵称、年龄、性别、兴趣爱好、自我介绍……，

var introduce = { name: '于维谦', age: 21, QQ: 839152795, hobby: ['basketball', 'online game'], gender: 'male' };
console.log(JSON.stringify(introduce));
console.log(JSON.stringify(introduce, ['age']));
console.log(JSON.stringify(introduce, null, ' '));
console.log(JSON.stringify(introduce, function (key, value) {
    if (typeof value === 'string') {
        return value.toUpperCase();
    }
    return value;
}));

//根据其他同学的JSON获得其个人资料，生成一个表格显示。
//暂时只有一个资料
var sequence = [{ "name": "于维谦", "age": 21, "QQ": 839152795, "hobby": ["basketball", "online game"], "gender": "male" }];

onload = function () {
    var establish = document.getElementsByTagName('body')[0];
    establish.appendChild(createTable(sequence));
};

var createTable = function (sequence) {
    var table = document.createElement('table');
    table.setAttribute('style', 'width:450px');
    var headline = document.createElement('caption');
    headline.innerHTML = '学生信息表';
    table.appendChild(headline);
    table.appendChild(createTr('姓名', '年龄', 'QQ', '兴趣爱好', '性别'));
    table.childNodes[1].setAttribute('style', 'background:#cae8ea');
    for (var i = 0; i < sequence.length; i++) {
        table.appendChild(createTr(sequence[i].name, sequence[i].age, sequence[i].QQ, sequence[i].hobby, sequence[i].gender));
    }
    return table;
};

var createTr = function (name, age, QQ, hobby, gender) {
    var tr = document.createElement('tr');
    var tdName = document.createElement('td');
    tdName.innerHTML = name;
    var tdAge = document.createElement('td');
    tdAge.innerHTML = age;
    var tdQQ = document.createElement('td');
    tdQQ.innerHTML = QQ;
    var tdHobby = document.createElement('td');
    tdHobby.innerHTML = hobby;
    var tdGender = document.createElement('td');
    tdGender.innerHTML = gender;
    tr.appendChild(tdName);
    tr.appendChild(tdAge);
    tr.appendChild(tdQQ);
    tr.appendChild(tdHobby);
    tr.appendChild(tdGender);
    return tr;
};



//使用正则表达式判断某个字符串:
//是否是合格的Email格式
//是否是小数（正负小数都可以）
//将所有以zyf - 开头的属性去掉zyf- （尽可能多的制造测试用例，比如：<a lzyf-old=''， 或者：<span>zyf---+---fyz</span> ……）

var regex = new RegExp("^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$");

var decimals = new RegExp("/^\d+\.d+$/");



//测试用例1:输出结果应为 <span id> 32 </span>
//var target = '<span zyf-id>32</span>';
////var reg = /zyf-/g;

//target = target.replace(reg, '');

//测试用例2:输出结果应该保持不变,但结果输出不正确
var testTwo = '<a lzyf-id></a>';
testTwo = testTwo.replace(reg, '');

//修改为符合前两项测试
var reg = /\b(zyf-)/;




//用class声明一个课程（Course），包含属性：name，startDate，endDate，students，以及方法：begin()和end() 

class Course {
    constructor(name, startDate, endDate, students) {
        this.name = name;
        this.startDate = startDate;
        this.endDate = endDate;
        this.students = students;
    }
    begin() {
        alert(this.name + '于' + this.startDate + '开课，共有5名同学' + this.students + '报名。');
    }
    end() {
        alert('欢迎' + this.name + '于' + this.startDate + '来到源栈');
    }
}


//生成两个课程对象：JavaScript和SQL

var JavaScript = new Course();
var SQL = new Course();


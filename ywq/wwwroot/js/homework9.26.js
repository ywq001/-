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

//var regex = new RegExp("^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$");

//var decimals = new RegExp("/^\d+\.d+$/");



//测试用例1:输出结果应为 <span id> 32 </span>
//var target = '<span zyf-id>32</span>';
////var reg = /zyf-/g;

//target = target.replace(reg, '');

//测试用例2:输出结果应该保持不变,但结果输出不正确
//var testTwo = '<a lzyf-id></a>';
//testTwo = testTwo.replace(reg, '');

//修改为符合前两项测试
//var reg = /\b(zyf-)/;




//用class声明一个课程（Course），包含属性：name，startDate，endDate，students，以及方法：begin()和end() 

//class Course {
//    constructor(name, startDate, endDate, students) {
//        this.name = name;
//        this.startDate = startDate;
//        this.endDate = endDate;
//        this.students = students;
//    }
//    begin() {
//        alert(this.name + '于' + this.startDate + '开课，共有5名同学' + this.students + '报名。');
//    }
//    end() {
//        alert('欢迎' + this.name + '于' + this.startDate + '来到源栈');
//    }
//}


//生成两个课程对象：JavaScript和SQL

//var JavaScript = new Course('javaScript', '2019年10月1日', '2020年4月1日', ['两开花、王枫、王平、采铃、老程']);
//var SQL = new Course();

//调用对象的begin()和end()方法，可以在控制台输出开课信息，如：JavaScript于2019年5月5日开课，共有5名同学（两开花、王枫、王平、采铃、老程）报名。
//console.log(JavaScript.begin());


//不修改class，动态的改变begin()方法，使其能影响所有Course对象

//Course.prototype.begin = function () {
//    console.log(this.name + '在' + this.startDate + '开课');
//};

//让end()方法为各自对象“自有”，其他对象无法修改
//class Course {
//    constructor(name, startDate, endDate, students) {
//        this.name = name;
//        this.startDate = startDate;
//        this.endDate = endDate;
//        this.students = students;
//        this.end = function () {
//            alert('欢迎' + this.name + '于' + this.startDate + '来到源栈');
//        };
//    }
//    begin() {
//        alert(this.name + '于' + this.startDate + '开课，共有5名同学' + this.students + '报名。');
//    }
//}

//在Course中使用getter和setter包装endDate，保证endDate不会小于startDate，也不会比startDate多出365天
//class Course {
//    constructor(name, startDate, endDate, students) {
//        this.name = name;
//        this.startDate = startDate;
//        this.endDate = endDate;
//        this.students = students;
//    }
//    get endDate() {
//        return this.startDate();
//    }
//    set endDate(value) {
//        if (value) {
//            value < startDate;
//            value - startDate > 365 * 24 * 60 * 60 * 1000;
//            throw new Error('');
//        }
//        this.endDate = value;
//    }
//}

//在封装作业的基础上，为Course添加两个子类：主修课（MajorCourse）和辅修课（ElectiveCourse）

//class Course {
//    constructor(name, startDate, endDate, students) {
//        this.name = name;
//        this.startDate = startDate;
//        this.endDate = endDate;
//        this.students = students;
//    }
//    begin() {
//        alert(this.name + '于' + this.startDate + '开课，共有5名同学' + this.students + '报名。');
//    }
//    end() {
//        alert('欢迎' + this.name + '于' + this.startDate + '来到源栈');
//    }

//}
//class MajorCourse extends Course {
//    constructor(name, startDate, endDate, students, sId) {
//        super(name, startDate, endDate, students);
//        this.sId = sId;
//    }
       
//}
//class ElectiveCourse extends Course {
//    constructor(name, startDate, endDate, students, sId) {
//        super(name, startDate, endDate, students);
//        this.sId = sId;
//    }
//}

//声明一个Stundent类，包含name和score两个属性，让Course的Students包含的是Student的对象
//class Student {
//    constructor(name, score) {
//        this.name = name;
//        this.score = score;
//    }
//}

//var Students = new Student();


//主修课需要参加考试，所以有一个Exam(student)方法；辅修课只需要测评，所以有一个方法Assess(student)

//class MajorCourse extends Course {
//    constructor(name, startDate, endDate, students, sId) {
//        super(name, startDate, endDate, students);
//        this.sId = sId;
//    }
//    Exam(student) {
//        alert('主修课需要考试');
//    }
//}
//class ElectiveCourse extends Course {
//    constructor(name, startDate, endDate, students, sId) {
//        super(name, startDate, endDate, students);
//        this.sId = sId;
//    }
//    Assess(student) {
//        alert('辅修课只需要测评');
//    }
//}
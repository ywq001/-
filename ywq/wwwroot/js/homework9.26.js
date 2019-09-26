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
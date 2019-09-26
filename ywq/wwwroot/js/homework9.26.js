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
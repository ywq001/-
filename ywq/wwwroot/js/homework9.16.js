//参考消息页面：完成勾选全选功能
//document.querySelector("[ywq-check-all]").addEventListener('click', function () {
//    var allFunctions = document.querySelectorAll("[ywq-check]");
//    if (document.querySelector("[ywq-check-all]").checked) {
//        for (var i = 0; i < allFunctions.length; i++) {
//            allFunctions[i] = true;
//        }
//    } else {
//        for (var j = 0; j < allFunctions.length; j++) {
//            allFunctions[j] = false;
//        }
//    }
//});


var selectAll = document.querySelector("[ywq-check-all]");
selectAll.onclick = function () {
    let select = document.querySelectorAll("[ywq-check]");
    for (var i = 0; i < select.length; i++) {
        select[i].checked = selectAll.checked;
    }
};
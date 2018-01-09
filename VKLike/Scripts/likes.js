function getDateTime() {
    var date = new Date();
    var result = date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + date.getDate() + " " + date.getHours() + ":" + date.getMinutes() + ":" + date.getSeconds() + "." + date.getMilliseconds();
    return result;
}

function addLike(page) {
    var data = {
        DateTime: getDateTime(),
        Page: page
    }
    $.post("/api/likes/add/", data);
}
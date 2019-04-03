/* JSLint edition 2019-01-31 */
/*jslint
    browser:true, devel:true, long:true
*/
/*global
    ajax_failure, ajax_get, ajax_join, ajax_prepare, ajax_succeed, alert,
    document, event_click_one_run
*/
/*property
    display, getElementById, style
*/
function ajax_prepare(ignore) {
    "use strict";
    var parameter = [];
    parameter = ajax_join(parameter, "list");
    parameter = ajax_join(parameter, "movie");
    //    parameter = ajax_join(parameter, "poster");
    return parameter;
}
function ajax_succeed(data) {
    "use strict";
    alert(data);
    /*
    var form = document.getElementById(data[0]);
    var list = form.elements;
    list.is_active.value = data[1];
    date_succeed(list.start_date, data[2]);
    date_succeed(list.end_date, data[3]);
    return form;
    */
}
function ajax_failure(code, text) {
    "use strict";
    alert(code + " : " + text);
}
event_click_one_run("#save", function (ignore) {
    document.getElementById("light").style.display = "none";
    document.getElementById("fade").style.display = "none";
    var form = document.getElementById("form");
    ajax_get("/ViewList/AddList", form);
});
event_click_one_run("#cancel", function (ignore) {
    document.getElementById("light").style.display = "none";
    document.getElementById("fade").style.display = "none";
});
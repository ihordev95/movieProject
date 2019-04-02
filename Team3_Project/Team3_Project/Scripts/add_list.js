/* JSLint edition 2019-01-31 */
/*jslint
    browser:true, devel:true, long:true
*/
/*global
    ajax_failure, ajax_join, ajax_prepare, ajax_send, ajax_succeed, alert, document, event_click_one_run
*/
/*property
    getElementById
*/
function ajax_prepare(ignore) {
    "use strict";
    var parameter = [];
    parameter = ajax_join(parameter, "list");
    parameter = ajax_join(parameter, "movie");
    parameter = ajax_join(parameter, "added");
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
event_click_one_run("#send", function (ignore) {
    var form = document.getElementById("dog");
    ajax_get("/ViewList/AddList", form);
});
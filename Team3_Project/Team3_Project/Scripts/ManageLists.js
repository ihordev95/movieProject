/* JSLint edition 2019-01-31 */
/*jslint
    browser:true, devel:true, long:true
*/
/*global
    ajax_failure, ajax_get, ajax_join, ajax_prepare, ajax_succeed, alert, document, event_click_one_run, prepare_list
*/
/*property
    join, length, push, querySelectorAll, value
*/
function prepare_list() {
    "use strict";
    var parameter = [];
    var array = document.querySelectorAll("input:checked");
    var index = array.length;
    while (index > 0) {
        index -= 1;
        parameter.push(array[index].value);
    }
    return parameter.join(",");
}
function ajax_prepare(ignore) {
    "use strict";
    var parameter = [];
    parameter = ajax_join(parameter, "list");
    parameter = ajax_join(parameter, "movie", prepare_list());
    return parameter;
}
function ajax_succeed(data) {
    "use strict";
    var array = data.split(",");
    var index = array.length;
    var item;
    var element;
    var parent;
    index -= 1; // last item is null because return string has extra comma (bug)
    while (index > 0) {
        index -= 1;
        item = array[index];
        element = document.getElementById(item);
        parent = element.parentElement; // label
        parent = parent.parentElement; // td
        parent = parent.parentElement; // tr
        parent.remove();
    }
}
function ajax_failure(code, text) {
    "use strict";
    alert(code + " : " + text);
}
event_click_one_run("#remove", function (ignore) {
    ajax_get("/ManageList/RemoveMovie", document);
});
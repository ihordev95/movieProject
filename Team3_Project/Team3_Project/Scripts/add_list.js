/* JSLint edition 2019-01-31 */
/*jslint
    browser:true
*/
/*global
    ajax_failure, ajax_get, ajax_join, ajax_prepare, ajax_succeed, alert,
    document, event_click_one_run
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
function ajax_succeed(ignore) {
    "use strict";
    return null;
}
function ajax_failure(code, text) {
    "use strict";
    alert(code + " : " + text);
}
event_click_one_run("#send", function (ignore) {
    var form = document.getElementById("dog");
    ajax_get("/ViewList/AddList", form);
});
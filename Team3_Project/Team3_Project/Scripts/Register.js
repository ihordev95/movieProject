/* JSLint edition 2019-01-31 */
/*jslint
    browser:true, devel:true, long:true
*/
/*global
    ajax_failure, ajax_get, ajax_join, ajax_prepare, ajax_succeed, alert, document, event_click_one_run
*/
/*property
    getElementById, value
*/
function ajax_prepare(ignore) {
    "use strict";
    var parameter = [];
    parameter = ajax_join(parameter, "email");
    parameter = ajax_join(parameter, "displayname");
    parameter = ajax_join(parameter, "password");
    parameter = ajax_join(parameter, "confirmpassword");
    return parameter;
}
function ajax_succeed(data) {
    "use strict";
    alert(data);
}
function ajax_failure(code, text) {
    "use strict";
    alert(code + " : " + text);
}
event_click_one_run("#register", function (ignore) {
    "use strict";
    ajax_get("/Register/AddUser", null);
});
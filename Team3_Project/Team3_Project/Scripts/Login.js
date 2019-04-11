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
    parameter = ajax_join(parameter, "password");
    return parameter;
}
function ajax_succeed(data) {
    "use strict";
    if (data === "Y") {
        alert("Passwords Match!");
    } else {
        alert("Login Failure!");
    }
}
function ajax_failure(code, text) {
    "use strict";
    alert(code + " : " + text);
}
event_click_one_run("#login", function (ignore) {
    "use strict";
    ajax_get("/Login/CheckPassword", null);
});
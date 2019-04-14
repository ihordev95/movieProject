/* JSLint edition 2019-01-31 */
/*jslint
    browser:true, devel:true, long:true
*/
/*global
    ajax_failure, ajax_get, ajax_join, ajax_prepare, ajax_succeed, alert, document, event_click_one_run
*/
/*property
    display, getElementById, style
*/
function ajax_prepare(ignore) {
    "use strict";
    var parameter = [];
    parameter = ajax_join(parameter, "user");
    parameter = ajax_join(parameter, "name");
    parameter = ajax_join(parameter, "hidden");
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
event_click_one_run("#save_new_list", function (ignore) {
    "use strict";
    document.getElementById("light").style.display = "none";
    document.getElementById("fade").style.display = "none";
    var form = document.getElementById("form");
    ajax_get("/ViewList/MakeList", form);
});
event_click_one_run("#cancel", function (ignore) {
    "use strict";
    document.getElementById("light").style.display = "none";
    document.getElementById("fade").style.display = "none";
});
event_click_one_run("#test1_create", function (ignore) {
    "use strict";
    document.getElementById("light").style.display = "block";
    document.getElementById("fade").style.display = "block";
});
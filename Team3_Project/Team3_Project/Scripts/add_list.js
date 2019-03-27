/* JSLint edition 2019-01-31 */
/*jslint
    browser:true, devel:true, long:false
*/
/*global
    ajax_prepare, ajax_join, ajax_succeed, date_prepare, date_succeed, document
*/
/*property
    elements, end_date, getElementById, is_active, start_date, value
*/
function ajax_prepare(ignore) {
    "use strict";
    /*
    var id = parent.getAttribute("data-id");
    var item = json[id];
    */
    var parameter = [];
    parameter = ajax_join(parameter, "activity_id", 27);
    parameter = ajax_join(parameter, "detail_date", "fish");
    parameter = ajax_join(parameter, "employee_id", 0.23);
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
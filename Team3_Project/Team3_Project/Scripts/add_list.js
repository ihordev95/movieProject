/* JSLint edition 2019-01-31 */
/*jslint
    browser:true, devel:true, long:false
*/
/*global
    ajax_prepare, ajax_succeed, date_prepare, date_succeed, document
*/
/*property
    elements, end_date, getElementById, is_active, start_date, value
*/
function ajax_prepare(form) {
    "use strict";
    return form;
}
function ajax_succeed(data) {
    "use strict";
    var form = document.getElementById(data[0]);
    var list = form.elements;
    list.is_active.value = data[1];
    date_succeed(list.start_date, data[2]);
    date_succeed(list.end_date, data[3]);
    return form;
}
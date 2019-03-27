/* JSLint edition 2019-01-31 */
/*jslint
    browser:true, devel:true, long:false
*/
/*global
    XMLHttpRequest, ajax_join, ajax_post, ajax_prepare, ajax_send, ajax_succeed,
    jQuery
*/
/*property
    DONE, join, onreadystatechange, open, post, push, readyState, responseText,
    send, setRequestHeader, split, status, statusText, unshift
*/
function ajax_join(parameter, name, value) {
    "use strict";
    parameter.push(name + "=" + value);
    return parameter;
}

function ajax_send(action, parameter, succeed, fail) {
    "use strict";
    var ajax = new XMLHttpRequest();
    ajax.open("POST", action, true);
    ajax.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    ajax.onreadystatechange = function () {
        if (ajax.readyState === XMLHttpRequest.DONE) {
            if (ajax.status === 200) {
                succeed(ajax.responseText.split("~"));
            } else {
                fail(ajax.status, ajax.statusText);
            }
        }
    };
    ajax.send(parameter.join("&"));
}

function ajax_post(page, method, parent) {
    "use strict";
    var parameter = ajax_prepare(parent);
    parameter.unshift("method=" + method);
    jQuery.post(page + ".do", parameter.join("&"), function (data) {
        ajax_succeed(data.split("~"));
    }, "text");
}
/* JSLint edition 2019-01-31 */
/*jslint
    browser:true
*/
/*global
    XMLHttpRequest, ajax_failure, ajax_get, ajax_join, ajax_post, ajax_prepare,
    ajax_send, ajax_succeed, document
*/
/*property
    DONE, getElementById, join, onreadystatechange, open, push, readyState,
    responseText, send, setRequestHeader, status, statusText, value
*/
function ajax_join(parameter, name, value) {
    "use strict";
    if (value === undefined || value === null) {
        value = document.getElementById(name).value;
    }
    parameter.push(name + "=" + value);
    return parameter;
}
function ajax_send(page, form) {
    "use strict";
    var ajax = new XMLHttpRequest();
    ajax.open("POST", page, true);
    ajax.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    ajax.onreadystatechange = function () {
        if (ajax.readyState === XMLHttpRequest.DONE) {
            if (ajax.status === 200) {
                ajax_succeed(ajax.responseText);
            } else {
                ajax_failure(ajax.status, ajax.statusText);
            }
        }
    };
    var parameter = ajax_prepare(form);
    ajax.send(parameter.join("&"));
}
function ajax_get(page, form) {
    "use strict";
    var ajax = new XMLHttpRequest();
    var parameter = ajax_prepare(form);
    ajax.open("GET", page + "?" + parameter.join("&"), true);
    ajax.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    ajax.onreadystatechange = function () {
        if (ajax.readyState === XMLHttpRequest.DONE) {
            if (ajax.status === 200) {
                ajax_succeed(ajax.responseText);
            } else {
                ajax_failure(ajax.status, ajax.statusText);
            }
        }
    };
    ajax.send();
}
function ajax_post(page, form) {
    "use strict";
    var ajax = new XMLHttpRequest();
    ajax.open("POST", page, true);
    ajax.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
    ajax.onreadystatechange = function () {
        if (ajax.readyState === XMLHttpRequest.DONE) {
            if (ajax.status === 200) {
                ajax_succeed(ajax.responseText);
            } else {
                ajax_failure(ajax.status, ajax.statusText);
            }
        }
    };
    var parameter = ajax_prepare(form);
    ajax.send(parameter.join("&"));
}
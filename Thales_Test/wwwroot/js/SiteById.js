var variables = "";

$(document).ready(function () {
    if (boolclient) {
        variables = getGET();
        debugger;
        var a = parseFloat(variables[2].employee_salary) * 12;
        var td;
        var tr = $("<tr/>");
        td = $("<td align='center'>" + variables[0].idEmp + "</td>");
        tr.append(td);
        td = $("<td align='center'>" + variables[1].employee_name + "</td>");
        tr.append(td);
        td = $("<td align='center'>" + variables[2].employee_salary + "</td>");
        tr.append(td);
        td = $("<td align='center'>" + variables[3].employee_age + "</td>");
        tr.append(td);
        td = $("<td align='center'>" + a + "</td>");
        tr.append(td);
        $("#tblTableClient").append(tr);
    }
  
});

function getGET() {
    var loc = document.location.href;
    var getString = loc.split('?')[1];
    if (getString == undefined) { return false; }
    var objget = getString.split('&');
    var getUrl = new Array();
    for (var i = 0, l = objget.length; i < l; i++) {
        var get = {};
        var tmp = objget[i].split('=');
        get[tmp[0]] = unescape(decodeURI(tmp[1]));
        get['stringVariable'] = tmp[0];
        getUrl.push(get);
    }
    return getUrl;
}

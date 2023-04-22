$(function () {
    $('#textbox_id').keydown(function (e) {
        if (e.shiftKey || e.ctrlKey || e.altKey) {
            e.preventDefault();
        } else {
            var key = e.keyCode;
            //alert(key)
            if (!((key == 8) || (key == 46) ||
                (key >= 35 && key <= 40)
                || (key >= 48 && key <= 57)
                || (key >= 96 && key <= 105))) {
                e.preventDefault();
            }
        }

    });
});

$(document).ready(function () {
    $("#btnSearch").on('click', function (event) {
        var id = $('#textbox_id').val();
        event.preventDefault();
        if (id != "") {
            //alert(id);
            GetEmployeebyId(id, "some", "some");
        }
        else {
            location.reload();
        }


    });
});

function GetEmployeebyId(id) {


    var controller = "Employee/";
    var url = controller + "EmployeeById";
    var idEmp;
    var employee_name;
    var employee_salary; 
    var employee_age;
    var profile_image;
    $.each(window.ListEmployees, function (ind, elem) {
        //console.log(elem.id);
        if (elem.id == id) {
            idEmp = elem.id;
            employee_name = elem.employeeName;
            employee_salary = elem.employeeSalary;
            employee_age = elem.employeeAge;
            profile_image = elem.profileImage;
        }
    }); 
    window.location.href = url + "/" + id + "?idEmp=" + idEmp + "&employee_name=" + employee_name + "&employee_salary=" + employee_salary + "&employee_age=" + employee_age + "&profile_image=" + profile_image;

  

  
    /*
    $.ajax({
        type: "post",
        url: url,
        async: true,
        cache: false,
        data: { "id": id, "repKeys": prepKeys, "repValues": prepValues },
        success: function (r) {
            flag = r;
            window.location.href = url + "/" + id;
        },
        error: function (xhr, status, error) {
            alert(error);
        }
    });
    return flag;*/
}

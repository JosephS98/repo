

$("#submit").click(function () {

    $(document).ready(function () {

        $('#gone').css({

            'visibility': 'hidden',

        });

        $("#AccuV").click(function (even) {

            alert($(this).prop("value"));

        });
        $("#Nexius").click(function (even) {

            alert($(this).prop("value"));

        });
        $("#Velex").click(function (even) {

            alert($(this).prop("value"));

        });
        $("#VelexSI").click(function (even) {

            alert($(this).prop("value"));

        });
        $("#Intelgica").click(function (even) {

            alert($(this).prop("value"));

        });
        $("#MyndCo").click(function (even) {

            alert($(this).prop("value"));

        });

    });

});

    var object = {};
    $anything = $('#questionAdd');

    for (i = 1; i < 6; i++) {


        object['option' + i] = $anything.find('#option' + i).text(); //This will grab the text


    }
    object['companyID'] = companyID;
    object['question'] = question;
    console.log(JSON.stringify(object))


    $.ajax({


        url: "/Home/addQuestion",
        type: "POST",
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(object),
        success: function (data) {
            if (data == null) {
                alert("Something went wrong");
            }
        },
        failure: function (data) {
            alert(data.dataText);
        },
        error: function (data) {
            alert(data.dataText);
        }
    });

    

$("#verify").click(function () {

    if ($("#a").val() == 'joeys' && $("#b") == 'x') {

        window.location.replace = "/home/addQuestion"

    } else

        alert("Incorrect username or password.")

});
$("#submitButton").click(function () {


    var Options = {};


    $questions = $('#optionData');


    for (i = 1; i < 6; i++) {
        if ($questions.find('#option' + i).prop('checked')) {
            Options['option' + i] = $questions.find('#option' + i).val();

        } else {

            Options['option' + i] = null;

        }

    }
    Options['companyID'] = companyID;
    Options['questionID'] = questionID;
    console.log(JSON.stringify(Options));
    
        
    $.ajax({

        url: "/Home/SaveData",
        type: "POST",
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        data: JSON.stringify(Options), //{ 'getQuestion': $('#getQuestion').val() }, { 'getCompany': $('#getCompany').val() }),                                                                                  
        success: function (data) {
            if (data == null) {
                alert("Something went wrong");
            } 
        },
        failure: function (data) {
            alert(data.dataText);
        },
        error: function (data) {
            alert(data.dataText);
        }
    });

    

    j++;

    $.ajax({

        url: "/Home/GetNextQuestion",
        type: "GET",
        data: { 'id':companyID, 'questionNum': j },
        success: function (data) {
            if (data == null) {
                alert("Something went wrong");
            }
            $('#questionArea').empty()
            $('#questionArea').html(data);
        },
        failure: function (data) {
            alert(data.dataText);
        },
        error: function (data) {
            alert(data.dataText);
        }
    });
    
});
    
var checked;
var i = 1;
var companyID;
var questionID;
var j = 1;
$(document).ready(function () {


    $("#AccuV").click(function (even) {

        companyID = ($(this).prop("value"));
        $('#gone').css({

            'visibility': 'hidden',

        });
    });
    $("#Nexius").click(function (even) {

        companyID = ($(this).prop("value"));
        $('#gone').css({

            'visibility': 'hidden',

        });
    });
    $("#Velex").click(function (even) {

        companyID = ($(this).prop("value"));
        $('#gone').css({

            'visibility': 'hidden',

        });
    });
    $("#VelexSI").click(function (even) {

        companyID = ($(this).prop("value"));
        $('#gone').css({

            'visibility': 'hidden',

        });
    });
    $("#Intelgica").click(function (even) {

        companyID = ($(this).prop("value"));
        $('#gone').css({

            'visibility': 'hidden',

        });
    });
    $("#MyndCo").click(function (even) {

        companyID = ($(this).prop("value"));
        $('#gone').css({

            'visibility': 'hidden',

        });

    });

});

$("#submit").click(function () {


    if (companyID == null) {

        alert("Please chose a company.")
    }
    });

finish = function () {
    var Options = {};
    checked = 0;

    $questions = $('#optionData');


    for (var i = 1; i < 6; i++) {
        if ($questions.find('#option' + i).prop('checked')) {
            if ($questions.find('#option' + i).prop('checked')) {

                checked += 1;
            }
            Options['option' + i] = $questions.find('#option' + i).val();

        } else {

            Options['option' + i] = null;

        }

    }
    if (checked == 0) {

        alert("Please check atleast one of the options.")

    } else {

        Options['companyID'] = companyID;
        Options['questionID'] = questionID;



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
        window.location.href = "/home/Index2";
    }
};

//var object = {};
//$anything = $('#questionAdd');

//for (i = 1; i < 6; i++) {


//    object['option' + i] = $anything.find('#option' + i).text(); //This will grab the text


//}
////object['companyID'] = companyID;
////object['question'] = question;
//console.log(JSON.stringify(object))


//$.ajax({


//    url: "/Home/addQuestion",
//    type: "POST",
//    dataType: 'json',
//    contentType: "application/json; charset=utf-8",
//    data: JSON.stringify(object),
//    success: function (data) {
//        if (data == null) {
//            alert("Something went wrong");
//        }
//    },
//    failure: function (data) {
//        alert(data.dataText);
//    },
//    error: function (data) {
//        alert(data.dataText);
//    }
//});

//});


$("#verify").click(function () {

    if ($("#a").val() == 'joeys' && $("#b").val() == 'x') {

        window.location.href = "/Question/Index2";

    } else {
        i += 1;
        alert("Incorrect username or password.");
    }

    if (i == 4) {
        alert("too many incorrect entries")
        window.location.href = "/home/Index";

    }
});

$("#verifyQuestions").click(function () {

    if ($("#question").val() == null || $("#option1").val() == null || $("#option2").val() == null || $("#option3").val() == null || $("#option4").val() == null || $("#option5").val() == null) {

        alert("At least one of the fields are blank.")

    } 


});



 goToNextPage = function() {
    
  
     checked = 0;

    var Options = {};


    $questions = $('#optionData');
      

    for (var i = 1; i < 6; i++) { 
        if ($questions.find('#option' + i).prop('checked')) {
            if ($questions.find('#option' + i).prop('checked')) {

                checked += 1;
            }
            Options['option' + i] = $questions.find('#option' + i).val();

        } else {

            Options['option' + i] = null;

        }

     }
     if (checked == 0) {

         alert("Please check atleast one of the options.")

     } else {
         Options['companyID'] = companyID;
         Options['questionID'] = questionID;



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
         console.log(j);
         $.ajax({

             url: "/Home/GetNextQuestion",
             type: "GET",
             data: { 'companyID': companyID, 'questionNum': j },
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

     }    
};

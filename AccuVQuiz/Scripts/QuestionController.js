

j = 1;


var $option1 = $('#option1');

var $option2 = $('#option2');

var $option3 = $('#option3');

var $option4 = $('#option4');

var $option5 = $('#option5');

//var $getQuestion = $('#getQuestion')

//var $getCompany = $('#getCompany')

//This could be done better
//$option1.change(function () {
 //   if ($option1.prop('checked')) {
//options.option1
  //  }
//});


$("#increment").click(function () {

    j++;
    console.log(j)
    $.ajax({

        url: "/Home/GetNextQuestion",
        type: "POST",
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        data: j,
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

});
$("#submitButton").click(function () {

  

    var Options = {};

    

    $questions = $('#optionData');


    

    for (i = 1; i < 6; i++) {
        if ($questions.find('#option' + i).prop('checked')) {
            Options['option' + i] = $questions.find('#option' + i).val();

        } else {

            Options['option' + i] = 'off';

        }

    }

 

    //console.log(results);
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
});
    
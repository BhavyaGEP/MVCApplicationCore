
$("#createForm").validate({
    rules: {
        errorClass: "msg-val",
        FirstName: "required",
        LastName: "required",
        EmailAddress: "required"       
    },
    messages: {
        FirstName: "First Name is required",
        LastName: "Last Name is required",
        EmailAddress: "Email id is required"       
    }
}

);
function FirstNameValidation() {
    var firstName = $("#FirstName").val();
    if (!firstName && !$("#FirstName-error")) {       
        $("#firstName").text("First Name is required");
    }
    else {
        $("#firstName").hide();
    }
}
function LastNameValidation() {
    var lastName = $("#LastName").val();
    if (!lastName && !$("#LastName-error")) {      
        $("#lastName").text("Last Name is required");
    }
    else {
        $("#lastName").hide();
    }
}
$("#FirstName").focusout(() => {
    FirstNameValidation();
})
$("#LastName").focusout(() => {
    LastNameValidation();   
})
function EmailIdValidation() {
    var email = $("#EmailAddress").val();
    var valid = true;
    if (email) {
        var emailreg = /^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$/;
        var valid = emailreg.test(email);
        if (!valid) {
            $("#emailId").text("Invalid Email Id");
            valid = false;
        }
        else {
            $("#emailId").hide();
        }
    } 
    else {
        $("#emailId").hide();
    }
    return valid;
}
function PhoneNumberValidation() {
    var PhoneNumber = $("#PhoneNumber").val();
    var valid = true;
    if (PhoneNumber) {
        if (PhoneNumber.length < 10) {
            $("#phoneNumber").text("Phone Number should not be less than 10 characters");
            valid = false;
        }
        var exp = /^[0-9-+]+$/;
        if (!(exp.test(PhoneNumber))) {
            $("#phoneNumber").text("Invalid Phone Nmuber");
            valid = false;
        }
        if (valid) {
            $("#phoneNumber").hide();
        }
    }
    return valid;
}
$("#EmailAddress").focusout(function validate() {
    EmailIdValidation();
})

$("#PhoneNumber").focusout(function validate() {
    PhoneNumberValidation();
})
$("#submitBtn").click(() => {
    return EmailIdValidation() && PhoneNumberValidation();
})




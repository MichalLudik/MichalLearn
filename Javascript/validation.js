//zakladna validacia
function validate(){
    if(document.myForm.Name.value == ""){
        alert("Prosim zadaj meno.");
        document.myForm.Name.focus();
        return false;
    }
}

//validacia dat
function validateEmail(){
    var emailId = document.myForm.EMail.value;
    var atpos = emailId.indexOf("@");
    var dotpos = emailId.indexOf(".");

    if(atpos < 1 || (dotpos - atpos < 1)){
        alert("Mas to na hovno");
        document.myForm.EMail.focus();
        return false;
    }

    return (true);
}
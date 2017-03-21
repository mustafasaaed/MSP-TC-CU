function ValidateContactForm() {
    var name = document.ContactForm.name;
    var email = document.ContactForm.email;
    var phone = document.ContactForm.telephone;
    var nocall = document.ContactForm.dontcall;
    var what = document.ContactForm.subject;
    var comment = document.ContactForm.comment;


    if (name.value == "")
    {
        window.alert("Please enter your name.");
        name.focus();
        return false;
    }

    if (email.value == "")
    {
        window.alert("Please enter a valid e-mail address.");
        email.focus();
        return false;
    }
    if (email.value.indexOf("@", 0) < 0) {
        window.alert("Please enter a valid e-mail address.");
        email.focus();
        return false;
    }
    if (email.value.indexOf(".", 0) < 0) {
        window.alert("Please enter a valid e-mail address.");
        email.focus();
        return false;
    }

    if ((nocall.checked == false) && (phone.value == "")) {
        window.alert("Please enter your telephone number.");
        phone.focus();
        return false;
    }

    if (what.selectedIndex < 1) {
        alert("Please tell us how we can help you.");
        what.focus();
        return false;
    }

    if (comment.value == "") {
        window.alert("Please provide a detailed description or comment.");
        comment.focus();
        return false;
    }
    return true;
}

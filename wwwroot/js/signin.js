$(document).ready(function () {
  $("form").submit(function (e) {
    const email = $("#email").val();
    const password = $("#password").val();
    if (email == "" || password == "") {
      $("#errormsg").html(
        "You need to provide your email and password to log in"
      );
      $("#errormsg").css("color", "red");
      e.preventDefault();
    }
  });
});

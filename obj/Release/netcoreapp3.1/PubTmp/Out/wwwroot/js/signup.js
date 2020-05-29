$(document).ready(function () {
  // function to validate form input
  $("form").submit(function (e) {
    const firstName = $("#fname").val();
    const lastName = $("#lname").val();
    const phone = $("#phone").val();
    const email = $("#email").val();
    const password = $("#pass").val();
    const confirmPassword = $("#confirmpass").val();
    if (
      firstName == "" ||
      lastName == "" ||
      phone == "" ||
      email == "" ||
      password == "" ||
      confirmPassword == ""
    ) {
      $("#errormsg").html("You need to fill out all fields to proceed*");
      $("#errormsg").css("color", "red");
      e.preventDefault();
    } else if (password !== confirmPassword) {
      $("#errormsg").html("Type in the same password in both fields");
      $("#errormsg").css("color", "red");
      $("#pass").css("border", "1px solid red");
      $("#confirmpass").css("border", "1px solid red");
      e.preventDefault();
    } else if (password.length < 7) {
      $("#errormsg").text("Password must be at least 7 characters long");
      $("#errormsg").css("color", "red");
      $("#pass").css("border", "1px solid red");
      $("#confirmpass").css("border", "1px solid red");
      e.preventDefault();
    }
  });
  $(".show").click(function () {
    if ($(".pwd").attr("type") == "password") {
      $(".pwd").attr("type", "text");
    } else {
      $(".pwd").attr("type", "password");
    }
  });
});

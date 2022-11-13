//slides
 
//tab
var tabLinks = document.querySelectorAll(".tablinks");
var tabContent = document.querySelectorAll(".tabcontent");

tabLinks.forEach(function (el) {
  el.addEventListener("click", openTabs);
});

function openTabs(el) {
  var btn = el.currentTarget;
  var electronic = btn.dataset.electronic;

  tabContent.forEach(function (el) {
    el.classList.remove("active");
  });

  tabLinks.forEach(function (el) {
    el.classList.remove("active");
  });

  document.querySelector("#" + electronic).classList.add("active");

  btn.classList.add("active");
}

$(".btn-nav-mobile").click((e) => {
  e.preventDefault();
  $(".nav-overlay").addClass("active");
  $(".nav-box-mobile").addClass("active");
});

$(".nav-mobile-close").click((e) => {
  e.preventDefault();
  $(".nav-overlay").removeClass("active");
  $(".nav-box-mobile").removeClass("active");
});
$(".nav-overlay").click((e) => {
  e.preventDefault();
  $(".nav-overlay").removeClass("active");
  $(".nav-box-mobile").removeClass("active");
});
 

$("#Header .wrapper .navbar .nav-item .nav-link").click((e) => {
  e.preventDefault();
  $(".nav-link").removeClass("active");
  $(e.currentTarget).addClass("active");
});

 

$(() => {
  const clickButton = document.getElementsByClassName("faqs-item");
  for (i = 0; i < clickButton.length; i++) {
    clickButton[i].addEventListener("click", function () {
      this.classList.toggle("active");
    });
  }
});

 
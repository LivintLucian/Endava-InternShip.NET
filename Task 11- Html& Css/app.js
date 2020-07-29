let registerLink = document.getElementById("register");
let isHidden = false;
let registerClass = document.querySelector(".register--form");
let loginClass = document.querySelector(".login--form");
let backButton = document.querySelector("#backButton");

function dynamicRegister() {
    registerLink.addEventListener("click", () => {
        registerClass.style.display = "block";
        loginClass.style.display = "none";
    });
}

function backToLogin() {
    backButton.addEventListener("click", () => {
        registerClass.style.display = "none";
        loginClass.style.display = "block";
    });
}

dynamicRegister();
backToLogin();
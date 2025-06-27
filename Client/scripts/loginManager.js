
function login() {
    const username = document.getElementById("username").value;
    const password = document.getElementById("password").value;

    if (username !== "user" || password !== "123") {
        alert("Usuario o contraseña incorrecto");
    } else {
        window.location.href = "index.html";
    }
}
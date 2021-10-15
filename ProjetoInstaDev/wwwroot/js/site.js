// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


var menu = document.getElementsByClassName;
function botaodoMenu(id) {
    var post = document.getElementById(id)
    var icone = document.getElementById("icone")

    if (post.style.display === "flex") {
        // esconder o menu
        post.style.display = "none";
        icone.classList.remove("fa-times")
        icone.classList.add("fa-ellipsis-v")
    } else {
        // Mostrar o menu 
        post.style.display = "flex";
        icone.classList.remove("fa-ellipsis-v")
        icone.classList.add("fa-times")
    }
}


function fecharMenu() {
    var fechar_menu =
        document.getElementById("Link");
    if (fechar_menu.style.display === "flex") {
        // esconder menu
        fechar_menu.style.display = "none";
    }
}

function botaodoMenu1(){
    var men = document.getElementById("Links");
    
    if (men.style.display == "flex") {
        men.style.display = "none";

    }else{
        men.style.display = "flex";
    }
}

// window.onresize = () => {
//     if(screen.width > 960) {
//         men.style.display = "flex";
//     } else {
//         men.style.display = "none";
//     }
// }
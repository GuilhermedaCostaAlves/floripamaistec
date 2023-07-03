function logar() {
    var email = document.getElementById("email").value;
    var senha = document.getElementById("senha").value;

    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if (!emailRegex.test(email)) {
        alert('Por favor, insira um endereço de e-mail válido.');
        return;
    }
    if (email != sessionStorage.getItem('usuario')) {
        alert('Email não corresponde')
    }
    if (senha.length < 10) {
        alert('A senha deve ter pelo menos 10 caracteres.');
        return;
    }

    if (email == sessionStorage.getItem('usuario')){
        window.location.href = 'home.html';
    }
}
function criarConta() {
    var email = document.getElementById("email").value;
    var senha = document.getElementById("senha").value;
    var confirmarSenha = document.getElementById("confirmarSenha").value;

    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

    if (!emailRegex.test(email)) {
        alert('Por favor, insira um endereço de e-mail válido.');
        return;
    }

    if (senha.length < 10) {
        alert('A senha deve ter pelo menos 10 caracteres.');
        return;
    }

    if (senha !== confirmarSenha) {
        alert('A senha e a confirmação de senha não correspondem.');
        return;
    }

    sessionStorage.setItem('usuario', email);
    window.location.href = 'home.html';
}
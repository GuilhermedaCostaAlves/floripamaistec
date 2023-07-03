fetch("https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking")

    .then(response => response.json())
    .then(data => {
        let Dados = document.getElementById("dados");
        data.reverse().forEach(element => {
            let div = document.createElement('div');
            div.classList.add('listaDeNomes');
            div.textContent = `Nome: ${element.nome}, Rank: ${element.rank}`;
            Dados.appendChild(div);

        });
    })

    .catch(error => console.error('Error', error));
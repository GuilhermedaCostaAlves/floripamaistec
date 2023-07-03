fetch("https://servicodados.ibge.gov.br/api/v1/censos/nomes/ranking")

    .then(response => response.json())
    .then(data => {
        let Dados = document.getElementById("dados");
        data.reverse();

        data.filter(element =>element.nome.length<=6)

            .forEach(element => {
                let lista = document.createElement('div');
                lista.classList.add('listaDeNomes');
                lista.textContent = `Nome: ${element.nome}, Rank: ${element.rank}`;
                Dados.appendChild(lista);
            });
    })

    .catch(error => console.error('Error', error));
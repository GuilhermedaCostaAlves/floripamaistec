var pessoa = {
    nome: "Guilherme",
    idade: 22,
    cidade: "Florianópolis"};
  
  var pessoaJSON = JSON.stringify(pessoa);

  localStorage.setItem("pessoa", pessoaJSON);

  var pessoaJSONRecuperada = localStorage.getItem("pessoa");
  
  var pessoaRecuperada = JSON.parse(pessoaJSONRecuperada);
  
  console.log(pessoaRecuperada);
  
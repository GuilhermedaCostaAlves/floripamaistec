var imputAberto;
var segundosContador;
var minutosContador;
var contador;

function selecionar(cardid){
    let cardSelecionado = document.getElementById(cardid);
    let imputSelecionado = cardSelecionado.children[0];

    imputSelecionado.classList.add('show');
    
    if (imputAberto){
        imputAberto= imputSelecionado;
    }else if(parseInt(imputAberto.value)!== parseInt(imputSelecionado.value)){
    setTimeout(()=>{
        imputAberto.classList.remove('show');
        imputSelecionado.classList.remove('show');
        imputAberto=null;
    },1000);
    } else{
        imputAberto =null;
    }
}
function iniciar()
{
    setInterval(() => {
        if (segundosContador == 59){
            segundosContador = 0;
            minutosContador++;
        }else{
            segundosContador++;
        }
        segundosSpam.innerHTML = segundosContador;
        minutosContador.innerHTML = minutosContador;
    }, 1000);
}

function pausar()
{

}

function reiniciar()
{

}


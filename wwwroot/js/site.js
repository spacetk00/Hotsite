// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function checa_form(form){

    var invalid = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/;

    let caixa_nome = document.querySelector('.msg-nome');
    caixa_nome.style.display = 'none';

    let caixa_email = document.querySelector('.msg-email');
    caixa_email.style.display = 'none';

    if(form.nome.value==""){
        
        caixa_nome.innerHTML = "Campo obrigatório";
        caixa_nome.style.display = 'block';
        form.nome.focus();
        return false;
    }

    if(form.email.value==""){
        
        caixa_email.innerHTML = "Campo obrigatório";
        caixa_email.style.display = 'block';
        form.email.focus();
        return false;
    }

    if (invalid.test(form.email.value)==false){
        caixa_email.innerHTML = "Digite um endereço de email válido";
        caixa_email.style.display = 'block';
        form.email.focus();
        return false;
    }
}
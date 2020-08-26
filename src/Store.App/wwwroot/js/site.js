﻿function AjaxModal() {
    $(document).ready(function () {
        debugger;
        $(function () {
            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click",
                function (e) {
                    debugger
                    $('#myModalContent').load(this.href,
                        function () {
                            $('#myModal').modal({
                                keyboard: true
                            }, 'show');
                            bindForm(this);
                        });
                    return false;
                });
        })

        function bindForm(dialog) {
            $('form', dialog).submit(function () {
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    success: function (result) {
                        if (result.success) {
                            $('#myModal').modal('hide');
                            $('#EnderecoTarget').load(result.url);
                        } else {
                            $('#myModalContent').html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            })
        }
    });
}

function BuscaCep() {
    $(document).ready(function () {

        function limpa_formulario_cep() {
            // Limpa valores do formulario de cep
            $("#Endereco_Logradouro").val("");
            $("#Endereco_Bairro").val("");
            $("#Endereco_Cidade").val("");
            $("#Endereco_Estado").val("");
        }

        // Quando o campo cep perde o foco
        $("#Endereco_Cep").blur(function () {

            // Nova variavel "cep" somente com digitos
            var cep = $(this).val().replace(/\D/g, '');

            // Verifica se o campo cep possui valor informado
            if (cep != "") {

                // Expressao regular para validar o CEP
                var validacep = /^[0-9]{8}$/;

                // Valida o formato do CEP
                if (validacep.test(cep)) {
                    // Preenche os campos com "..." enquanto realiza requisicao
                    $("#Endereco_Logradouro").val("...");
                    $("#Endereco_Bairro").val("...");
                    $("#Endereco_Cidade").val("...");
                    $("#Endereco_Estado").val("...");

                    // Consulta o webservice viacep.com.br/
                    $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?",
                        function (dados) {
                            if (!("erro" in dados)) {
                                // Atualiza os campos com os valores da consulta
                                $("#Endereco_Logradouro").val(dados.logradouro);
                                $("#Endereco_Bairro").val(dados.bairro);
                                $("#Endereco_Cidade").val(dados.localidade);
                                $("#Endereco_Estado").val(dados.uf);
                            } else {
                                // Se não encontrar o CEP
                                limpa_formulario_cep();
                                alert("CEP não encontrado");
                            }
                        });
                } else {
                    // CEP inválido
                    limpa_formulario_cep();
                    alert("Formato CEP inválido");
                }
            } else {
                // cep sem valor, limpeza do formulário
                limpa_formulario_cep();
            }
        });
    });
}

$(document).ready(function () {
    $("#msg_box").fadeOut(2500);
})
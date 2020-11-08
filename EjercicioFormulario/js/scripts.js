

$(document).ready(function () {

    $("#error").hide();
    $("#enviado").hide();

    $("#enviar").on("click", function(){

        if (  $("#nombre").val().length == 0 || $("#apellido").val().length == 0  ) {
            $("#error").show();
        } else {
            $("#error").hide();
            $("#enviado").show();
        }
    });

    $("#limpiar").on("click", function(){       
        $("#form")[0].reset();
        $("#error").hide();
        $("#enviado").hide();

    });
    
});
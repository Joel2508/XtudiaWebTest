$(document).ready(function () {
    init();
})

function init() {
    $('#btn-Create').on('click', function () {
        var lButton = $('.btn-Create');
        var user = {
            Nombres: $("#txtNombres").val(),
            Apellidos: $("#txtApellidos").val(),
            Documento: $("#txtDocumento").val(),
            EMail: $("#txtEMail").val(),
            UserName: $("#txtUserName").val(),
            Password: $("#txtPassword").val(),

        };
        $.ajax({
            url: '../../User/CreateUser',
            type: 'POST',
            data: user,
            success: function (data) {
                toastr.success('Indicadores registrados correctamente', 'Registro de Indicadores');
                lButton.stop();
                init();
            },
            error: function (error) {
                lButton.stop();
                toastr.error('El usuario no pudo ser registrado', 'Registro de Usuario');
            },
        });
    });    
};
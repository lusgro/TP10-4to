function MostrarTemporadas(id) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/ObtenerTemporadas',
        data: {idSerie: id},
        success:
            function (response) {
                $("#ModalList").html("");
                response.forEach(element => {
                    $("#ModalList").append(
                        "<li>Temporada " + element.numeroTemporada + ": " + element.tituloTemporada + "</li>"
                    );
                });
            },
    });
}

function MostrarActores(id) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/ObtenerActores',
        data: {idSerie: id},
        success:
            function (response) {
                $("#ModalList").html("");
                response.forEach(element => {
                    $("#ModalList").append(
                        "<li>" + element.nombre + "</li>"
                    );
                });
            },
    });
}

function MostrarInfo(id) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/ObtenerInfo',
        data: {idSerie: id},
        success:
            function (response) {
                console.log(response);
                $("#ModalList").html(
                    "<li>Año de inicio: " + response.añoInicio + "</li>" +
                    "<li>Sinopsis: " + response.sinopsis + "</li>"
                );
            },
    });
}
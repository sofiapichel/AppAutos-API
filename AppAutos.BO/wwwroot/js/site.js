// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let btnMenu = document.querySelector("#btn-menu");
let btnCloseMenu = document.querySelector("#btn-close-menu");


btnMenu.addEventListener("click", () => {

    document.querySelector(".menu-vertical").classList.add("open");
    document.querySelector("body").classList.add("modal-open");


})

btnCloseMenu.addEventListener("click", () => {

    document.querySelector(".menu-vertical").classList.remove("open");
    document.querySelector("body").classList.remove("modal-open");

});


$(document).ready(function () {
    $("table").DataTable({
        "language": {
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "Ningún dato disponible en esta tabla",
            "sInfo": "Mostrando  _END_ / _TOTAL_ registros",
            "sInfoEmpty": "Sin datos",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            },
        },
        "pagingType": "numbers",
    });
});

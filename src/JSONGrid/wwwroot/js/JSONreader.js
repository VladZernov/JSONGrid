$(document).ready(function () {

    function GetProducts() {
        $.ajax({
            type: "get",
            url: '/Products/GetJson',
            dataType: 'json',
            success: function (data) {
                console.log("success");
                for (var i = 0; i < data.Products.length; i++) {
                    $('#productGrid').append("<li class='Products' id='Product_" + i + "'></li>");
                    $('#Product_' + i).append("<a href= Products/" + data.Products.Id + "/>");
                    $('#Product_' + i).append("<img src=" + data.Products[i].ImgSrc + ">");
                    $('#Product_' + i).append("<h3>" + data.Products[i].Name + "</h3>");
                    $('#Product_' + i).append("<h3>" + data.Products[i].Price + "</h3>");
                    $('#Product_' + i).append("<p>" + data.Products[i].FullDescription + "</p>");
                }
            },
            statusCode: {
                404: function () {
                    alert('There was a problem with the server.  Try again soon!');
                }
            }
        });
    };
    GetProducts();
});
$(document).ready(function () {
    $("#button").click(function () {
        html2canvas($("#canvas"), {
            onrendered: function (canvas) {
                // canvas is the final rendered <canvas> element
                var myImage = canvas.toDataURL("image/png");
                $("#imagearea").attr("src", myImage);;
            }
        });
    });
});
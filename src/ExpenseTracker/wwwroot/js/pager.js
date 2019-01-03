$(document).ready(function () {
    $("#pagerLinks").on("click", function (ev) {
        ev.preventDefault();
        console.log(ev.trget)
    });
});
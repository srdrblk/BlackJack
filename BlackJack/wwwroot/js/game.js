function addCard(playerId) {

    $.ajax({
        url: "/Home/Player",
        type: 'GET',
        data: { Id: playerId },
        success: function (resp) {

            $('#' + playerId).html($('#' + playerId, resp).html());

        }
    });
}

function addPlayer() {

    $.ajax({
        url: "/Home/AddPlayer",
        type: 'GET',
       
        success: function () {

            location.reload();
        }
    });
}

function RestartGame() {

    $.ajax({
        url: "/Home/RestartGame",
        type: 'GET',

        success: function () {

            location.reload();

        }
    });
}

function CloseGame() {

    $.ajax({
        url: "/Home/CloseGame",
        type: 'GET',

        success: function () {

            location.href = "/";

        }
    });
}

function ClosePlayer(playerId) {

    $.ajax({
        url: "/Home/ClosePlayer",
        type: 'GET',
        data: { Id: playerId },
        success: function () {

            location.reload();

        }
    });
}
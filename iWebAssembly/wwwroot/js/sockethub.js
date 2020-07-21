"use strict"
var connection = new signalR.HubConnectionBuilder().withUrl("/SocketHub").build();

connection.on("ReceiveMessage", function (user, message)
{
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    alert(encodedMsg);
});
connection.start().then(function () {
    alert("ready");
});

function SendMessage(user, message)
{
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();

}
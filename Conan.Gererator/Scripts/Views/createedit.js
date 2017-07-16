$(document).ready(function () {
    $("#Agility").change(function () {
        $('#agilityValue').html($("#Agility").val());
        calculateShortForm();
    });
    $("#Brawn").change(function () {
        $('#brawnValue').html($("#Brawn").val());
        calculateShortForm();
    });
    $("#Coordination").change(function () {
        $('#coordinationValue').html($("#Coordination").val());
        calculateShortForm();
    });
    $("#Personality").change(function () {
        $('#personalityValue').html($("#Personality").val());
        calculateShortForm();
    });
    $("#Willpower").change(function () {
        $('#willpowerValue').html($("#Willpower").val());
        calculateShortForm();
    });
    $("#Intelligence").change(function () {
        $('#intelligenceValue').html($("#Intelligence").val());
        calculateShortForm();
    });
    $("#Awareness").change(function () {
        $('#awarenessValue').html($("#Awareness").val());
        calculateShortForm();
    });

    $("#Combat").change(function () {
        $('#CombatValue').html($("#Combat").val());
        calculateShortForm();
    });
    $("#Knowledge").change(function () {
        $('#KnowledgeValue').html($("#Knowledge").val());
        calculateShortForm();
    });
    $("#Fortitude").change(function () {
        $('#FortitudeValue').html($("#Fortitude").val());
        calculateShortForm();
    });
    $("#Senses").change(function () {
        $('#SensesValue').html($("#Senses").val());
        calculateShortForm();
    });
    $("#Social").change(function () {
        $('#SocialValue').html($("#Social").val());
        calculateShortForm();
    });
    $("#Movement").change(function () {
        $('#MovementValue').html($("#Movement").val());
        calculateShortForm();
    });
});

function calculateShortForm() {
    var sf = $("#Name").val();
    sf += "(?) ";
    sf += "S? "

    var agility = Number($("#Agility").val());
    var combat = Number($("#Combat").val());
    sf += "M" + (agility + combat) + "/" + combat + " ";

    var coordination = Number($("#Coordination").val());
    sf += "PR" + (coordination + combat) + "/" + combat + " ";

    var personality = Number($("#Personality").val());
    var social = Number($("#Social").val());
    sf += "Me" + (coordination + combat) + "/" + combat+ " ";

    var movement = Number($("#Movement").val());
    var brawn = Number($("#Brawn").val());
    sf += "Mv" + (Math.ceil((agility + brawn) / 2) + movement) + "/" + movement + " ";



    $("#shortform").text(sf);
}
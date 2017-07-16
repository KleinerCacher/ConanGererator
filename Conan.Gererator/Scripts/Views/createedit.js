$(document).ready(function () {
    $("#Agility").change(function () {
        $('#agilityValue').html($("#Agility").val());
    });
    $("#Brawn").change(function () {
        $('#brawnValue').html($("#Brawn").val());
    });
    $("#Coordination").change(function () {
        $('#coordinationValue').html($("#Coordination").val());
    });
    $("#Personality").change(function () {
        $('#personalityValue').html($("#Personality").val());
    });
    $("#Willpower").change(function () {
        $('#willpowerValue').html($("#Willpower").val());
    });
    $("#Intelligence").change(function () {
        $('#intelligenceValue').html($("#Intelligence").val());
    });
    $("#Awareness").change(function () {
        $('#awarenessValue').html($("#Awareness").val());
    });

    $("#Combat").change(function () {
        $('#CombatValue').html($("#Combat").val());
    });
    $("#Knowledge").change(function () {
        $('#KnowledgeValue').html($("#Knowledge").val());
    });
    $("#Fortitude").change(function () {
        $('#FortitudeValue').html($("#Fortitude").val());
    });
    $("#Senses").change(function () {
        $('#SensesValue').html($("#Senses").val());
    });
    $("#Social").change(function () {
        $('#SocialValue').html($("#Social").val());
    });
    $("#Movement").change(function () {
        $('#MovementValue').html($("#Movement").val());
    });
});
$(document).ready(function() {
    $('#select').change(function () {
        $('#searchText').focus();
    });
    $("#SearchForm").submit(function (event) {
        event.preventDefault();
        $.ajax({
            method: this.method.toUpperCase(),
            url: this.action,
            data: {
                type: $("#select").val(),
                query: $("#searchText").val()
            },
            success: function(result) {
                $("#partialResult").empty().append(result);
            }
        });
    });


    function SetStars(starElement) {
        var index = +starElement.dataset.index;

        $(starElement.parentNode).children().each(function (starIndex) {
            if (starIndex <= index) {
                $(this).removeClass("far").addClass("fas");
            } else {
                $(this).removeClass("fas").addClass("far");
            }
        })
    }

    $(".fa-star").click(function (event) {
        SetStars(this);

        $("#count").text(+this.dataset.index + 1);
        $("#count2").val(+this.dataset.index + 1);
    });
    $(".fa-star").hover(function (event) {
        SetStars(this);
    }, function (event) {
            var value = +$("#count").text();
            $(".fa-star").each(function(index) {
                if (value === +this.dataset.index +1) {
                    SetStars(this);
                }
            });
    });
    })
$(document).ready(function() {
    $('#select').change(function () {
        $('#searchText').focus();
    });

    $("#searchText").on("input", function (event) {
        var changeWindow = false;

        var inputValue = this.value;
        $('#searchTextOptions').find('.SearchTextOption').each(function(index) {
            if (this.value == inputValue) {
                changeWindow = true;
                window.location.href = this.dataset.href;
            }
        });

        if (!changeWindow) {
            var parentForm = document.getElementById("SearchForm");
            GetSearchOptions(parentForm);
        }
    });

    function GetSearchOptions(form) {
        $.ajax({
            method: form.method.toUpperCase(),
            url: form.action,
            data: {
                type: $("#select").val(),
                query: $("#searchText").val()
            },
            success: function (result) {
                $("#searchTextOptions").empty().append(result);
            }
        });
    }

    $("#SearchForm").submit(function (event) {
        event.preventDefault();
        GetSearchOptions(this);
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
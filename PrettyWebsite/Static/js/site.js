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

        if (inputValue.length && inputValue.length >= 3) {
            if (!changeWindow) {
                var parentForm = document.getElementById("SearchForm");
                GetSearchOptions(parentForm);
            }
        }
    });

    $("#searchBtn").click(function(event) {
        var parentForm = document.getElementById("SearchForm");
        GetSearchOptions(parentForm);
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


    $(".lazyloaded").each(function(index) {
        $(this).attr("src", this.dataset.src);
    });



    $(".EPiServerForms").addClass("container").addClass("m-4").addClass("g-3");
    $(".Form__Title").addClass("text-warning").addClass("mb-2").addClass("row");
    $(".Form__MainBody").addClass("input-group").addClass("mt-3").addClass("p-2").addClass("row");
    $(".FormStep").addClass("row").addClass("align-content-sm-center").addClass("w-100").addClass("w-100");
    $(".FormTextbox").addClass("col-sm-6").addClass("row");
    $(".Form__Status").addClass("text-warning").addClass("row").addClass("ml-4");
    $(".FormTextbox__Input").addClass("form-control").addClass("align-content-sm-center");
    $(".Form__Element__Caption").css("display","none");
    $(".Form__Element__ValidationError").addClass("text-danger");
    $(".FormSubmitButton").addClass("btn").addClass("btn-primary").addClass("col-sm-3").addClass("ml-5");

    $('input',".EPiServerForms")
        .not(':button, :submit, :reset, :hidden')
        .val('')
        .prop('checked', false)
        .prop('selected', false);
})
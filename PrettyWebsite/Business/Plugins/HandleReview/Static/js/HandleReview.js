$(document).ready(function() {
    $("#DeleteReviewsForm").submit(function(event) {
        event.preventDefault();
        event.stopPropagation();
        var checkboxes = $('.form-check-input:checkbox:checked');
        var externalIds = [];
        checkboxes.each(function() {
            externalIds.push(this.value);
        });
        var data = {
            externalIds
        };
        var method = this.method.toUpperCase();
        var url = this.action;
        if (data.externalIds.length) {
            $.ajax({
                method,
                url,
                data,
                xhrFields: {
                    withCredentials: true
                },
                success: function (result,a,b,c) {
                    console.log(result);
                    if (result.redirect) {
                        window.location.href = result.redirect;
                    }
                },
                error: function (error) {
                    console.log(error);
                },
            });
        }
    });
});
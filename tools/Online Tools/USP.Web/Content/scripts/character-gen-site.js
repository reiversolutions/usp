$(document).ready(function () {
    $('.form-control.point-select').slider(
        {
            max: 5,
            value: $(this).val()
        }
    );
});
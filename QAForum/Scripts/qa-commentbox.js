(function commentBoxContainer(window) {
    window.controlHelpers = window.controlHelpers || {};
    window.controlHelpers.commentBox = new CommentBox();

    function CommentBox(sender) {

        this.Get = function (sender) {
            $.ajax({
                type: 'POST',
                url: '../Post/CommentBox',
                data: window.model[0],
                success: function (data) {
                    $(sender).replaceWith(data);
                }
            });
        };

        (function init() {
            //future init code goes here
        })();
    }
})(window);
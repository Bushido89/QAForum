(function commentBoxContainer(window) {
    window.controlHelpers = window.controlHelpers || {};
    window.controlHelpers.commentBox = new CommentBox();

    function CommentBox(sender) {

        this.Get = function (sender) {
            $.get('../Post/CommentBox',
                function (data) {
                    $(sender).replaceWith(data);
                }
            );
        };

        (function init() {
            //future init code goes here
        })();
    }
})(window);
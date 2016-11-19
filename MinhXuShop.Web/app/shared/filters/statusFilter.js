(function (app) {
    app.filter('statusFilter', function () {
        return function (input) {
            if (input == true) {
                return 'kich hoat';
            } else {
                return 'khoa';
            }
        }
    });
})(angular.module('minhxushop.common'));

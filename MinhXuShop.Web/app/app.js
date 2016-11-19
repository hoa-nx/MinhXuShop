/// <reference path="D:\Woking\Web\Asp.NetMVC\AngularJS-MVC\Git\MinhXuShop.Web\Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('minhxushop', ['minhxushop.common', 'minhxushop.products']).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvier, $urlRouterProvider) {
        $stateProvier.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();
/// <reference path="Assets/admin/libs/angular/angular.js" />

(function () {
    angular.module('minhxushop',
        ['minhxushop.common',
         'minhxushop.products',
          'minhxushop.product_categories'
        ]).config(config);
    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvier, $urlRouterProvider) {
        $stateProvier
            .state('base', {
                url:'',
                templateUrl: "/app/shared/views/baseView.html",
                abstract: true
            })
            .state('login', {
                url: "/login",
                templateUrl: "/app/components/login/loginView.html",
                controller: "loginController"
            })
            .state('home', {
                url: "/admin",
                parent: 'base',
                templateUrl: "/app/components/home/homeView.html",
                controller: "homeController"
            });
        $urlRouterProvider.otherwise('/login');
    }
})();
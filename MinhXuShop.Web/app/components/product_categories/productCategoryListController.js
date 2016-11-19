(function (app) {
    app.controller('productCategoriesListController', productCategoriesListController);

    productCategoriesListController.$inject = ['$scope','apiService'];
    function productCategoriesListController($scope, apiService) {
        $scope.productCategories = [];
        $scope.getProductCategories = getProductCategories;

        function getProductCategories() {
            apiService.get('/api/productcategory/getall', null, function (result) {
                $scope.productCategories = result.data;
                console.log('Load productcategory ok');
            }, function () {
                console.log('Load productcategory failed.');
            });

        }
        $scope.getProductCategories();
    }
})(angular.module('minhxushop.product_categories'));
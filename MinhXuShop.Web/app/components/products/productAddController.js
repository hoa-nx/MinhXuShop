
(function (app) {
    app.controller('productAddController', productAddController);

    productAddController.$inject = ['apiService', '$scope', 'notificationService', '$state'];

    function productAddController(apiService, $scope, notificationService, $state) {
        $scope.product = {
            CreatedDate: new Date(),
            Price : 0,
            Status: true
        }

        $scope.ckeditorOptions = {
            language: 'vi',
            height : '200px'
        }

        $scope.AddProduct = AddProducty;

        function AddProducty() {
            apiService.post('api/product/create', $scope.product,
                function (result) {
                    notificationService.displaySuccess(result.data.Name + ' đã được thêm mới.');
                    $state.go('products');
                }, function (error) {
                    notificationService.displayError('Thêm mới không thành công.');
                });
        }
        function loadProductCategory() {
            apiService.get('api/productcategory/getallparents', null, function (result) {
                $scope.productCategories = result.data;
            }, function () {
                console.log('Get product category failed');
            });
        }

        $scope.ChooseImage = function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $scope.product.Image = fileUrl;
            }
            finder.popup();
        }

        loadProductCategory();
    }

})(angular.module('minhxushop.products'));
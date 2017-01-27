// JavaScript source code
angular.module('ahApp')
    .controller('appCtrl', function ($scope, $http, DataService) {
        $scope.angularTitle = "Angular title";
        $scope.returnValue;
        $scope.addItem = function (item) {
            $scope.returnValue = DataService.addItem(item);
        };
        $scope.getItems = function () {
            $scope.returnValue = DataService.getItems();
        };
    });
var DataService = angular.module('ahApp');
DataService.factory('DataService', ['$http', function ($http) {
    var urlBase = 'localhost';
    var DataServiceOp = {};

    DataServiceOp.getItems = function () {
        //return $http.get(urlBase + '/Get');
        return "get function";
    };

    DataServiceOp.addItem = function (item) {
        //return $http.post(urlBase + '/Add', item);
        return "add function";
    };
    return DataServiceOp;
}]);
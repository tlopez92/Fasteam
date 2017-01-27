
(function (ga)
{
    'use strict';

    ga.angular = angular.module('ahApp', ['ngRoute']);
    ga.angular.config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/', {
            controller: 'appCtrl',
            templateUrl: 'modules/User/view.html'
        });
    }]);
})(window.ahApp || (window.ahApp = {}));
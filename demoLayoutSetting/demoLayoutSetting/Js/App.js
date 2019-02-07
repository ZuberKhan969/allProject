var app = angular.module("AppModule", ['ngRoute']);

app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $locationProvider.hashPrefix('');

    $routeProvider.when('/Html', {
        templateUrl: '../Pages/HtmlPage1.html',
        controller: 'demoController'
    });
}]);
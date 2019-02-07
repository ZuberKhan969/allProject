var app = angular.module("mymodule", []);
app.service("myService", function ($http) {
    this.message = function () {
        alert("You are in service");
        var promise =
            $http({
                method: 'GET',
                url: 'http://localhost:21757/' + 'showData/GetData',
                async: false,
                headers: { 'Content-Type': 'application/json;charset=UTF-8' }
            });
        return promise;
    }
});

app.controller("myController", function ($scope, myService) {

   function Init(){
       //On Load Event
       $scope.click();
   }
    //onclick Event
    $scope.click = function () {
        
        var data = myService.message();
        data.then(function (result) {
            $scope.bigData = result.data;
        })
    }
    Init();
})
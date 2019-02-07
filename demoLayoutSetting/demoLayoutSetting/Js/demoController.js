app.controller("demoController", function ($scope, demoService) {
    function Init() {
        $scope.getMessage();
    }
    $scope.getMessage = function () {
        alert("I am in config");
        var promise = demoService.getAllMessage();
        promise.then(function (result) {
            $scope.data = result.data;
        })
    };
    Init();
})
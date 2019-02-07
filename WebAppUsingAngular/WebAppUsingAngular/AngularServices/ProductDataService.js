

(function () {
    var URL = productManagement.GetLocalHost();
    var app = angular.module("testapp", []);
    app.service("ProductDataService", function ($http) {
        this.fatchData = function () {
            var promise =
                $http({
                    method: 'GET',
                    url: URL + '/showData/GetData',
                    async: false,
                    headers: { 'Content-Type': 'application/json; charset=UTF-8 ' }
                });
            return promise;
        }

    });
});
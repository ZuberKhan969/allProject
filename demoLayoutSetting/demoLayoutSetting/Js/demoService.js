app.service("demoService", function ($http) {
    this.getAllMessage = function () {
        var promise = 
            $http({
                method: 'GET',
                url: 'http://localhost:36993/' + 'demo/getMessage',
                async:false,
                headers:{'Content-Type':'application/json; charset = UTF-8'}
            })
        return promise;
    }
})
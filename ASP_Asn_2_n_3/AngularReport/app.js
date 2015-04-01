(function () {
    var app = angular.module("gsreport", []);

    var ReportController = function ($scope, $http) {

        var host = "localhost";
        var port = "57290";
        var baseURL = "http://" + host + ":" + port + "/";
        var loginURL = baseURL + "Token";

        $scope.performLogin = function () {
            var data = "&grant_type=password&" + "username=" + $scope.username + "&password=" + $scope.password;

            $http({
                method: 'POST',
                url: loginURL,
                headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                data: $.param({grant_type: "password", username: $scope.username, password: $scope.password})
            })
                .success(function (response) {
                    $scope.report = response;
                    $scope.showlogin = false;
                    $scope.showreport = true;
                })
                .error(function (response) {
                    $scope.loginerror = response.error_description;
                });


        }

        $scope.showlogin = true;
    };

    app.controller("ReportController", ["$scope", "$http", ReportController]);
}());
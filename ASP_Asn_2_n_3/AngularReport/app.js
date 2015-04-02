﻿(function () {
    var app = angular.module("gsreport", []);

    var ReportController = function ($scope, $http) {

        var host = "localhost";
        var port = "57290";
        var baseURL = "http://" + host + ":" + port + "/";
        var loginURL = baseURL + "Token";
        var apiURL = baseURL + "api/Report/";

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
                    $scope.showMonthYear = true;
                })
                .error(function (response) {
                    $scope.loginerror = response.error_description;
                });
        }

        var getMonthYear = function () {            
            $http.get(apiURL + "getyear")
            .success(function (response) {
                var json = JSON.stringify(response);
                var parser = JSON.parse(json);
                $scope.yearData = response;
            });
        }

        $scope.loadReport = function () {
            var month = $scope.selectedMonth;
            var yearID = $scope.selectedYear;
            if (typeof month === "undefined" || typeof yearID === "undefined") { return; }
            if (month.length >= 0 && yearID.length >= 0) {
                retrieveReport(month, yearID);
            }
            $scope.month = $("#selectMonth>option:selected").html();
            $scope.year = $("#selectYear>option:selected").html();


            var m_names = new Array("January", "February", "March", "April", "May", "June", "July", "August", "September",
                "October", "November", "December");
            var d = new Date();
            $scope.currentdate = m_names[d.getMonth()] + " " + d.getDate() + "/" + d.getFullYear();
        }

        var retrieveReport = function (monthNum, yearID) {
            $http.get(apiURL + "getReport?monthnum=" + monthNum + "&yearid=" + yearID)
                .success(function (response) {

                });
        }

        $scope.showlogin = true;
        getMonthYear();
        $scope.showMonthYear = true;
        $scope.showreport = true;
    };


    app.controller("ReportController", ["$scope", "$http", ReportController]);
}());
angular.module('myApp', []);

var myController = function($scope) {
    $scope.myInput = "world!";
};

var locationList = function($scope, $http) {
    $http.get("/api/AppData")
        .then(function(response) {
            $scope.data = {
                locations: response.data
            };
        });

    $scope.range = function(min, max, step) {
        step = step || 1;
        var input = [];
        for (var i = min; i <= max; i += step) {
            input.push(i);
        }
        return input;
    };
}

angular
    .module("myApp")
    .controller("myController", myController)
    .controller("locationList", locationList);
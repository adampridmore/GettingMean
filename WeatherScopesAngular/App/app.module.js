angular.module('myApp', []);

var myController = function($scope) {
    $scope.myInput = "world!";
};

var locationList = function($scope) {
    $scope.data = {
        locations: [
            {
                name: 'Burger King',
                address: '125 High Street, Reading, RG6 1PS'
            }, {
                name: 'Costy',
                address: '7 Stanborough Road, Plymouth, PL9 8SP'
            }
        ]
    }
}

angular
    .module('myApp')
    .controller('myController', myController)
    .controller('locationList', locationList);
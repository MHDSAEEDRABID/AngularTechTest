function Employee($scope, $http) {
    $scope.animationsEnabled = true;
    $scope.open = function ($modal) {
        var modalInstance = $modal.open({
            animation: $scope.animationsEnabled,
            templateUrl: 'Modal.html',
            controller: 'modalController',
            size : 'lg'
        })
    }
    $http.get("api/Get").then(function (response) {
        $scope.Employees = response.data;
        $scope.Total = function () {
            var total = 0;
            for (count = 0; count < $scope.Employees.length; count++) {
                total += parseInt($scope.Employees[count].salary, 10);
            }
            return total;
        }
        console.log(response.data);
    });
}
function modalController($scope) {
    $scope.name = "SAEED"
}
angular.module('myApp', ['ngAnimate','ui.bootstrap','angularUtils.directives.dirPagination']).
    controller("EmployeeController", Employee).
    controller("modalController", modalController)
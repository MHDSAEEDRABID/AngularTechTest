function Employee($scope, $http) {
    $http.get("api/Get").then(function (response) {
        $scope.Employees = response.data;
        console.log(response.data);
    });
}
angular.module('myApp', ['angularUtils.directives.dirPagination']).
    controller("EmployeeController", Employee)
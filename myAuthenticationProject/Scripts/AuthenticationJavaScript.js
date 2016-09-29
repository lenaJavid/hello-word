var app = angular.module("appModule", []);

app.controller("EmployeeController", function ($scope, AuthenticateService) {

    $scope.AddEmployee = function () {
        CityService.AddEmployee(this.employee)
            .success(function (employees) {
                $scope.employees = employees;
            })
            .error(function (error) {
                error.code;
                $scope.status = 'Unable to Insert employee data: ' + error.message;
            });
    }


    $scope.DelEmployee = function () {
        CityService.DeleteEmployee(this.employee)
            .success(function (employees) {
                $scope.employees = employees;
                $scope.employee = null;
            })
            .error(function (error) {
                error.code;
                $scope.status = 'Unable to Delete employee: ' + error.message;
            });
    }

    $scope.EditEmployee = function () {
        CityService.EditEmployee(this.employee)
        .success(function (employees) {
            $scope.employees = employees;
        })
        .error(function (error) {
            error.code;
            $scope.status = 'Unable to Update employee data: ' + error.message;
        });
    }
});



app.factory("AuthenticateService", ['$http', function ($http){
    var urlBase = 'http://localhost:5117/api';
    var AuthenticateService = {};


}]);


app.factory("EmployeeService", ['$http', function ($http) {
    var urlBase = 'http://localhost:5117/api';
    var EmployeeService = {};

    EmployeeService.GetEmployee = function () {
        return $http.get(urlBase + '/Employee');
    };

    EmployeeService.AddEmployee = function (employee) {
        var response = $http({
            method: "Post",
            url: urlBase + '/Employee',
            dataType: "json",
            data: JSON.stringify(employee)
        });
        return response;
    };

    EmployeeService.DeleteEmployee = function (employee) {
        var response = $http({
            method: "Delete",
            url: urlBase + '/Employee' + employee.Eid
        });
        return response;
    };

    EmployeeService.UpdateEmployee = function (employee) {
        var response = $http({
            method: "Put",
            url: urlBase + '/Employee' + employee.Eid,
            dataType: "json",
            data: JSON.stringify(employee)
        });
        return response;
    };
}]);
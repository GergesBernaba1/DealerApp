function getAllEmployee(url) {
    $http.get(url).then(function (response) {
        $scope.hello = response.data;
    });

}

function getEmployeeById(url,Id) {
    $http.get(url).then(function (response) {
        $scope.hello = response.data;
    });
}
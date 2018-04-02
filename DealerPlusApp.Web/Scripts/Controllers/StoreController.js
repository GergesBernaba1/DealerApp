var StoreController = function ($scope, $http) {
    $scope.models = {
        helloAngular: 'Hello This is Store'
    };

    $scope.currentPage = 1;
    $scope.numPerPage = 9;
    $scope.maxSize = 5;
    $scope.storeList = [];
    $scope.filteredStores = [];

    //$http.get('/Store/GetStoreList/' + 1).success(function (data) {
    //    console.log(data);
    //    $scope.storeList = data;
    //    $scope.$watch('currentPage + numPerPage', function () {
    //        var begin = (($scope.currentPage - 1) * $scope.numPerPage)
    //        , end = begin + $scope.numPerPage;

    //        $scope.filteredStores = $scope.storeList.slice(begin, end);
    //    });
    //});

    $scope.getListOfStores = function (searchWord) {

        var datasent = {
            keyword: searchWord,
            marketId:1
        };

        var config = {
            params: datasent,
            headers: { 'Accept': 'application/json' }
        };

        $http.get('/Store/SearchStores', config).then(function (response) {
            $scope.storeList = response.data;
            $scope.$watch('currentPage + numPerPage', function () {
                var begin = (($scope.currentPage - 1) * $scope.numPerPage), end = begin + $scope.numPerPage;
                $scope.filteredStores = $scope.storeList.slice(begin, end);
            });
        });



    };


};

StoreController.$inject = ['$scope', '$http'];







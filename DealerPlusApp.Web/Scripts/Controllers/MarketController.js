var MarketController = function ($scope, $http) {
    $scope.models = {
        helloAngular: 'Hello This is Market'
    };

    $scope.currentPage = 1;
    $scope.numPerPage = 9;
    $scope.marketList = [];
    $scope.filteredMarkets = [];
    $scope.maxSize = 5;
  


    $scope.getListOfMarkets = function (searchWord) {
        
        var datasent = {
            keyword: searchWord
        };

        var config = {
            params: datasent,
            headers: { 'Accept': 'application/json' }
        };

        $http.get('/Market/SearchMarkets', config).then(function(response) {
            $scope.marketList = response.data;
            $scope.$watch('currentPage + numPerPage', function () {
                var begin = (($scope.currentPage - 1) * $scope.numPerPage)
                , end = begin + $scope.numPerPage;
                $scope.filteredMarkets = $scope.marketList.slice(begin, end);
                console.log($scope.filteredMarkets);
            });

          
        });




    };
};

MarketController.$inject = ['$scope','$http'];







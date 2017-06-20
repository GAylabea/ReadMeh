app.controller('BookController', ['$scope', '$http', '$routeParams','$location', function ($scope, $http, $routeParams, $location) {
    console.log("BookController connected!");
    $scope.book = {};
    $http.get("api/get/" + $routeParams.id) // this is the actual injection for the html
    .then(function (result) {
        $scope.book = result.data;
        console.log(result.data);
    })

    $scope.updateBook = function () {
        $http.put("api/put/" + $routeParams.id, $scope.book)
        .then(function (result) {
            $location.path("/list");
        })
    };
}]);
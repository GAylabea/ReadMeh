app.controller('ListAllBooksController', ['$scope', '$http', '$location', function ($scope, $http, $location) {
    console.log("hello world!");
    $scope.books = [];
    $scope.GetAllBooks = function () {
        $http.get("api/listall", $scope.book)
    .then(function (result) {
        $scope.books = result.data;
        console.log(result.data);
    })
    }
    $scope.GetAllBooks();
}]);
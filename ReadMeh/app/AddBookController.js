app.controller('AddBookController', ['$scope', '$http', '$location', function ($scope, $http, $location) {
    console.log("AddBook connected!");
    $scope.book = {};
    $scope.addBook = function () {
        $http.post("api/book", $scope.book)
    .then(function (result) {
        $location.path("/welcome");
        $scope.book = {};
        });
    }
}]);
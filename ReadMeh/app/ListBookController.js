app.controller('ListBookController', ['$scope', '$http', '$location', function ($scope, $http, $location) {
    console.log("ListBook connected!");
    $scope.books = [];
    $scope.GetBooks = function () {
        $http.get("api/list", $scope.book)
    .then(function (result) {
        $scope.books = result.data;
        console.log(result.data);
    })
    }
    $scope.delete = function (id, index) {
        console.log("why???")
        $http.delete("api/delete/" + id)
        .then(function (result) {
            $scope.books.splice(index, 1); // this is deleting index one item of our array
        })
    }
    $scope.editBook = function (id) {
        $location.path("/book/edit/" + id);
    }
    $scope.GetBooks(); // does this reload the book without the deleted book? Or is it necessary??
}]);


    var app = angular.module("readmeh", ['ngRoute'])
        app.config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
            $routeProvider
                .when('/welcome', {
                    templateUrl: 'app/partials/Welcome.html',
                    controller: 'WelcomeController'
                })
                .when('/login', {
                    templateUrl: 'app/partials/Login.html',
                    controller: 'LoginController'
                })
                .when('/signup', {
                    templateUrl: 'app/partials/SignUp.html',
                    controller: 'SignupController'
                })
                .when('/add', {
                    templateUrl: 'app/partials/AddBook.html',
                    controller: 'AddBookController'
                })
                .when('/list', {
                    templateUrl: 'app/partials/ListBooks.html',
                    controller: 'ListBookController'
                })
                .when('/listall', {
                    templateUrl: 'app/partials/ListAllBooks.html',
                    controller: 'ListAllBooksController'
                })
                .when('/book/:id', { // the colon means the parameter that we injected into the BookController(routeParams)
                    templateUrl: 'app/partials/Book.html',
                    controller: 'BookController'
                })
                .when('/book/edit/:id', {
                    templateUrl: 'app/partials/EditBook.html',
                    controller: 'BookController'
                })
                .otherwise({
                    redirectTo: '/welcome'
                });
            
            $locationProvider.html5Mode(true);
               
        }])
    app.run(["$http", function ($http) {

        var token = sessionStorage.getItem('token');

        if (token)
            $http.defaults.headers.common['Authorization'] = `bearer ${token}`;
    }
    ])

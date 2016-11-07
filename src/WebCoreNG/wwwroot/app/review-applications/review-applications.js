angular
    .module('adv-app.review', ['ui.router'])
    .config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
            $stateProvider
                .state('review', {
                    url: '/',
                    controller: 'ReviewController',
                    controllerAs: 'vm',
                    templateUrl: '/app/review-applications/review-applications.html'
                });
        }]);
angular
    .module('adv-app.emailValidation', ['ui.router'])
    .config(['$stateProvider', '$urlRouterProvider', function ($stateProvider, $urlRouterProvider) {
            $stateProvider
                .state('validation', {
                    url: '/',
                    controller: 'EmailValidationController',
                    controllerAs: 'vm',
                    templateUrl: '/app/email-validation/email-validation.html'
                });
        }]);
import 'material-design-lite/material.css!'

import 'material-design-lite'
import angular from 'angular'
import 'angular-animate'
import 'angular-resource'
import 'angular-ui-router'

import 'app/email-validation/load'
import 'app/review-applications/load'

import { LogDecorator, ExternalLogger } from 'app/utils/LogDecorator';

angular
  .element( document )
  .ready( function() {

    let appName = 'adv-app';
    let $log = new ExternalLogger();

    $log = $log.getInstance( "BOOTSTRAP" );
    $log.debug( "Initializing '{0}'", [ appName ] );
    
    let body = document.getElementsByTagName("body")[0];
    let app  = angular
          .module( appName, [ 
            'adv-app.emailValidation',
            'adv-app.review',
            'ui.router',
            'ngAnimate',
            'ngResource',
            ])
          .run([
              '$rootScope', '$state', '$stateParams', '$timeout',
            function ($rootScope, $state, $stateParams, $timeout) {
                // It's very handy to add references to $state and $stateParams to the $rootScope
                // so that you can access them from any scope within your applications.For example,
                // <li ng-class="{ active: $state.includes('contacts.list') }"> will set the <li>
                // to active whenever 'contacts.list' or one of its decendents is active.
                $rootScope.$state = $state;
                $rootScope.$stateParams = $stateParams;
                $rootScope.$on("$stateChangeError", console.log.bind(console));
                $rootScope.$on('$stateChangeSuccess', function () {
                  $timeout(function () {
                    componentHandler.upgradeAllRegistered();
                  });
                });
            }
          ])
          .config( ['$provide', '$stateProvider', '$urlRouterProvider', 
                    function($provide, $stateProvider, $urlRouterProvider, $mdThemingProvider){
            $urlRouterProvider.otherwise('/');
            LogDecorator($provide);
          }]);
          
    angular.bootstrap( body, [ app.name ], { strictDi: false })
  });
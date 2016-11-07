angular
    .module('adv-app.emailValidation')
    .controller('EmailValidationController', EmailValidationController);

EmailValidationController.$inject = ['$state'];	
		
function EmailValidationController($state){
    let vm = this;
    
    vm.validate = function(){
        $state.go('review', {});
    }
}
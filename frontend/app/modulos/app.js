(function(angular){

var keretaModule = angular.module('kereta', [	
	//Modulos do Kereta
	'kereta.frota',	
	
	//Componentes
	'ngCookies',
    'ngResource',
    'ngSanitize',
    'ngRoute',
    'ngAnimate'
	]);

})(angular);
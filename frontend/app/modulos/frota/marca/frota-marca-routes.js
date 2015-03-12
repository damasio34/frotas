(function(angular){

var marcaModule = angular.module('kereta.frota.marca');

marcaModule.config(function($routeProvider){

	$routeProvider
    .when('/frota/marca/listar', {
        templateUrl: 'modulos/frota/marca/frota-marca-listar-view.html',
        controller: 'MarcaListarCtrl',        
    })
    .when('/frota/marca/editar/{id}', {
        templateUrl: 'modulos/frota/marca/frota-marca-incluir-editar-view.html',
        controller: 'MarcaIncluirEditarCtrl',        
    });

});

})(angular);
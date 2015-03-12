(function(angular){

 var marcaModule = angular.module('kereta.frota.marca');
    return marcaModule.controller('MarcaIncluirEditarCtrl', function($scope, $routeParams ){
        $scope.mensagem = 'teste ' + $routeParams.id; 
      });

})(angular);
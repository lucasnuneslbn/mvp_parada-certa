angular.module('starter.controllers', [])

.controller('AppCtrl', function($scope, $state, $ionicModal, $timeout) {

  // With the new view caching in Ionic, Controllers are only called
  // when they are recreated or on app start, instead of every page change.
  // To listen for when this page is active (for example, to refresh data),
  // listen for the $ionicView.enter event:
  //$scope.$on('$ionicView.enter', function(e) {
  //});	
  // Create the login modal that we will use later
  $ionicModal.fromTemplateUrl('templates/login.html', {
    scope: $scope
  }).then(function(modal) {
    $scope.modal = modal;
  });
   
   
  // Form data for the login modal
  $scope.loginData = {};

  // Triggered in the login modal to close it
  $scope.closeLogin = function() {
    $scope.modal.hide();
  };

  // Open the login modal
  $scope.login = function() {
    $scope.modal.show();
  };
  
   // Perform the login action when the user submits the login form
  $scope.doLogin = function() {
    console.log('Doing login', $scope.loginData);

    // Simulate a login delay. Remove this and replace with your login
    // code if using a login system
    $timeout(function() {
      $scope.closeLogin();
    }, 1000);
  };

  
  // Verifica se o usuário ainda esta conectado via facebook
  $scope.watchLoginChange = function() {
	  var _self = this;
	  FB.Event.subscribe('auth.authResponseChange', function(res) {
		if (res.status === 'connected') {
		  /*
		   The user is already logged,
		   is possible retrieve his personal info
		  */
		  _self.getUserInfo();
		  /*
		   This is also the point where you should create a
		   session for the current user.
		   For this purpose you can use the data inside the
		   res.authResponse object.
		  */
		}
		else {
		  /*
		   The user is not logged to the app, or into Facebook:
		   destroy the session on the server.
		  */
		}
	  });
   }
 
   // Recupera os dados do usuário(nome, email) logado com facebook
   $scope.getUserInfo = function() {
  	  var _self = this;
	  FB.api('/me', function(res) {
		$rootScope.$apply(function() {
		  $rootScope.user = _self.user = res;
		});
	  });
	}
	
	// Logout
	$scope.logout = function() {
	  var _self = this;
	  FB.logout(function(response) {
		$rootScope.$apply(function() {
		  $rootScope.user = _self.user = {};
		});
	  });
	}
	
	
	$scope.irPara = function(state){
	  $state.go(state,{});
	}
	
})

.controller('AppMapa', function($scope, $state, $ionicModal, $timeout) {
    self = this;
	$scope.initMap = function() {
		
		map = new google.maps.Map(
			document.getElementById('map'),
			{center: new google.maps.LatLng(-33.91722, 151.23064), zoom: 14});
		var iconBase =
			'https://developers.google.com/maps/documentation/javascript/examples/full/images/';
		var icons = {
		  parking: {
			icon: iconBase + 'parking_lot_maps.png'
		  },
		  info: {
			icon: 'img/parceiro.png'
		  }
		};
		var features = [
		  {
			position: new google.maps.LatLng(-33.91721, 151.22630),
			type: 'info'
		  }, {
			position: new google.maps.LatLng(-33.91539, 151.22820),
			type: 'info'
		  }, {
			position: new google.maps.LatLng(-33.91747, 151.22912),
			type: 'info'
		  }, {
			position: new google.maps.LatLng(-33.91910, 151.22907),
			type: 'info'
		  }, {
			position: new google.maps.LatLng(-33.91725, 151.23011),
			type: 'info'
		  }
		];
	
		// Create markers.
		for (var i = 0; i < features.length; i++) {
		  var marker = new google.maps.Marker({
			position: features[i].position,
			icon: icons[features[i].type].icon,
			map: map
		  });
		  attachSecretMessage(marker, map);
		};
		
		
   	}
	
	// Attaches an info window to a marker with the provided message. When the
    // marker is clicked, the info window will open with the secret message.
    function attachSecretMessage(marker, map) {
		marker.addListener('click', function() {
			$('.popContent').css('display','block')
		});
	}
	
	
  	
   $scope.initMap();
});
// Ionic Starter App

// angular.module is a global place for creating, registering and retrieving Angular modules
// 'starter' is the name of this angular module example (also set in a <body> attribute in index.html)
// the 2nd parameter is an array of 'requires'
// 'starter.controllers' is found in controllers.js
angular.module('starter', ['ionic', 'starter.controllers'])

.run(function($ionicPlatform) {
  $ionicPlatform.ready(function() {
    // Hide the accessory bar by default (remove this to show the accessory bar above the keyboard
    // for form inputs).
    // The reason we default this to hidden is that native apps don't usually show an accessory bar, at
    // least on iOS. It's a dead giveaway that an app is using a Web View. However, it's sometimes
    // useful especially with forms, though we would prefer giving the user a little more room
    // to interact with the app.
    if (window.cordova && window.Keyboard) {
      window.Keyboard.hideKeyboardAccessoryBar(true);
    }

    if (window.StatusBar) {
      // Set the statusbar to use the default style, tweak this to
      // remove the status bar on iOS or change it to use white instead of dark colors.
      StatusBar.styleDefault();
    }
	
	/**
	 * Login with Facebook
	*/
 	window.fbAsyncInit = function() {
		// Executed when the SDK is loaded
		FB.init({
		  /*
		   The app id of the web app;
		   To register a new app visit Facebook App Dashboard
		   ( https://developers.facebook.com/apps/ )
		  */
		  appId: '1530242897156362',
		  /*
		   Adding a Channel File improves the performance
		   of the javascript SDK, by addressing issues
		   with cross-domain communication in certain browsers.
		  */
		  channelUrl: 'app/channel.html',
		  /*
		   Set if you want to check the authentication status
		   at the start up of the app
		  */
		  status: true,
		  /*
		   Enable cookies to allow the server to access
		   the session
		  */
		  cookie: true,
		  /* Parse XFBML */
		  xfbml: true
		});
		//sAuth.watchAuthenticationStatusChange();
	};
	(function(d){
		// load the Facebook javascript SDK
		var js,
		id = 'facebook-jssdk',
		ref = d.getElementsByTagName('script')[0];
		if (d.getElementById(id)) {
		  return;
		}
		js = d.createElement('script');
		js.id = id;
		js.async = true;
		js.src = "//connect.facebook.net/en_US/all.js";
		ref.parentNode.insertBefore(js, ref);
	  }(document));
	
  });
  
})

.config(function($stateProvider, $urlRouterProvider) {
  $stateProvider
  
  .state('app', {
    url: '/app',
    abstract: true,
    templateUrl: 'templates/menu.html',
    controller: 'AppCtrl'
  })

  .state('app.home', {
    url: '/home',
	 views: {
        'menuContent': {
          templateUrl: 'templates/home.html',
          controller: 'AppMapa'
        }
      }
  })

  .state('app.login', {
    url: '/login',
    templateUrl: 'templates/login.html',
	controller: 'AppCtrl'
  })
  
  .state('app.saude', {
    url: '/saude',
	 views: {
        'menuContent': {
          templateUrl: 'templates/saude.html',
          controller: 'AppCtrl'
        }
      }
  })
  
  .state('app.premios', {
    url: '/premios',
	 views: {
        'menuContent': {
          templateUrl: 'templates/premios.html',
          controller: 'AppCtrl'
        }
      }
  })
  
  .state('app.atividades', {
    url: '/minhas-atividades',
	 views: {
        'menuContent': {
          templateUrl: 'templates/minhas-atividades.html',
          controller: 'AppCtrl'
        }
      }
  })
  
  .state('app.consultas-online', {
    url: '/consultas-online',
	 views: {
        'menuContent': {
          templateUrl: 'templates/consulta-online.html',
          controller: 'AppCtrl'
        }
      }
  })
  
  
   .state('app.meu-cadastro', {
    url: '/meu-cadastro',
	 views: {
        'menuContent': {
          templateUrl: 'templates/meu-cadastro.html',
          controller: 'AppCtrl'
        }
      }
  })
  
  .state('app.duvidas', {
    url: '/duvidas',
	 views: {
        'menuContent': {
          templateUrl: 'templates/duvidas.html',
          controller: 'AppCtrl'
        }
      }
  })
  
   .state('app.suporte', {
    url: '/suporte',
	 views: {
        'menuContent': {
          templateUrl: 'templates/suporte.html',
          controller: 'AppCtrl'
        }
      }
  })
  
  
  // if none of the above states are matched, use this as the fallback
  $urlRouterProvider.otherwise('/app/home');
});



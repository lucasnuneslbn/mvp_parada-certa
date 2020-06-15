<?php
	function isPortable() {
		$iphone = strpos($_SERVER['HTTP_USER_AGENT'],"iPhone");
		$ipad = strpos($_SERVER['HTTP_USER_AGENT'],"iPad");
		$android = strpos($_SERVER['HTTP_USER_AGENT'],"Android");
		$palmpre = strpos($_SERVER['HTTP_USER_AGENT'],"webOS");
		$berry = strpos($_SERVER['HTTP_USER_AGENT'],"BlackBerry");
		$ipod = strpos($_SERVER['HTTP_USER_AGENT'],"iPod");
		$symbian =  strpos($_SERVER['HTTP_USER_AGENT'],"Symbian");
		return ($iphone || $ipad || $android || $palmpre || $ipod || $berry || $symbian == true);
	}
?>
<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <!--
  Customize this policy to fit your own app's needs. For more guidance, see:
      https://github.com/apache/cordova-plugin-whitelist/blob/master/README.md#content-security-policy
  Some notes:
      * gap: is required only on iOS (when using UIWebView) and is needed for JS->native communication
      * https://ssl.gstatic.com is required only on Android and is needed for TalkBack to function properly
      * Disables use of inline scripts in order to mitigate risk of XSS vulnerabilities. To change this:
          * Enable inline JS: add 'unsafe-inline' to default-src
  -->
  <meta http-equiv="Content-Security-Policy" content="default-src * 'self' 'unsafe-inline' 'unsafe-eval' data: gap: content:">
  <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, minimum-scale=1, user-scalable=no, minimal-ui, viewport-fit=cover">
  <meta name="apple-mobile-web-app-capable" content="yes">
  <meta name="apple-mobile-web-app-status-bar-style" content="default">
  <meta name="theme-color" content="#2196f3">
  <meta name="format-detection" content="telephone=no">
  <meta name="msapplication-tap-highlight" content="no">  
  <?php
  
  	echo '
 	 <meta http-equiv="cache-control" content="max-age=0" />
    <meta http-equiv="cache-control" content="no-cache" />
    <meta http-equiv="expires" content="0" />
    <meta http-equiv="expires" content="Tue, 01 Jan 1980 1:00:00 GMT" />
    <meta http-equiv="pragma" content="no-cache" />';
	?>

  
  <!-- For social medias -->
  <title>Parada Certa</title>
  <meta name="description" content="Aplicativo para monitorar a saúde do caminhoneiro e gerar benefícios para o mesmo através de um sistema de pontuação." />
  <meta property="og:url"           content="https://paradacerta.lbnsistemas.com.br/" />
  <meta property="og:type"          content="app" />
  <meta property="og:title"         content="Parada Certa" />
  <meta property="og:description"   content="Aplicativo para monitorar a saúde do caminhoneiro e gerar benefícios para o mesmo através de um sistema de pontuação." />
  <meta property="og:image"         content="" />
  
  <?php
	// Verifica se é telefone portátio e redireciona para a index_app.php
	if(isPortable()) {
		echo "<script>window.location='index.html';</script>";
		exit();
	}
	?>
</head>
<body class="home-header ">
  <style>
  	
		
		.home-header .phone {
		  position: absolute;
		  background: #111;
		  border-radius: 55px;
		  box-shadow: 0px 0px 0px 2px #aaa;
		  top: 50%;
		  left:50%;
		  margin-left:-160px;
		  width: 320px;
		  height: 568px;
		  padding: 105px 25px;
		  transform: translateY(-50%);
		}
		@media (max-width: 960px) {
		  .home-header .phone {
			right: 5px;
		  }
		}
		.home-header .phone:after {
		  content: '';
		  position: absolute;
		  width: 60px;
		  height: 60px;
		  left: 50%;
		  margin-left: -30px;
		  bottom: 20px;
		  border-radius: 100%;
		  box-sizing: border-box;
		  border: 5px solid #333;
		}
		.home-header .phone:before {
		  content: '';
		  width: 60px;
		  height: 10px;
		  border-radius: 10px;
		  position: absolute;
		  left: 50%;
		  margin-left: -30px;
		  background: #333;
		  top: 50px;
		}
		.home-header .phone .statusbar {
		  position: absolute;
		  width: 320px;
		  height: 20px;
		  background: url(img/status-bar.png);
		  left: 50%;
		  margin-left: -160px;
		  top: 100px;
		  -webkit-background-size: 100% auto;
		  background-size: 100% auto;
		}
		.home-header .phone iframe {
		  width: 320px;
		  height: 548px;
		  display: block;
		  width: 100%;
		  margin-top: 20px;
		}
		.home-header .phone.phone-android {
		  border-radius: 30px;
		  width: 360px;
		  padding: 60px 10px;
		  height: 640px;
		}
		.home-header .phone.phone-android .theme-switch {
		  margin-top: -9px;
		}
		.home-header .phone.phone-android:before {
		  width: 14px;
		  height: 14px;
		  border-radius: 50%;
		  position: absolute;
		  left: 50%;
		  margin-left: -7px;
		  background: #666;
		  top: 25px;
		}
		.home-header .phone.phone-android:after {
		  content: '';
		  width: 8px;
		  height: 8px;
		  border-radius: 50%;
		  position: absolute;
		  left: 50px;
		  background: #444;
		  top: 30px;
		  margin-left: 0;
		}
		.home-header .phone.phone-android iframe {
		  width: 360px;
		  height: 615px;
		  margin-top: 25px;
		  border-radius: 12px;
		}
		.home-header .phone.phone-android .statusbar {
		  width: 360px;
		  height: 25px;
		  background-image: url(img/status-bar-android.png);
		  margin-left: -180px;
		  top: 60px;
		}
		.home-header .phone .theme-switch {
		  position: absolute;
		  right: 100%;
		  margin-right: 2px;
		  top: 70px;
		  white-space: nowrap;
		}
		.home-header .phone .theme-switch a {
		  text-align: center;
		  background: #b72f20;
		  text-decoration: none;
		  color: #fff;
		  padding: 5px 5px 5px 20px;
		  border-radius: 35px 0 0 35px;
		  display: block;
		  font-size: 12px;
		  transition: 200ms;
		  opacity: 0.5;
		  background: rgba(0, 0, 0, 0.3);
		  position: relative;
		}
		.home-header .phone .theme-switch a span {
		  display: block;
		}
		.home-header .phone .theme-switch a.active,
		.home-header .phone .theme-switch a:hover {
		  opacity: 1;
		}
		.home-header .phone .theme-switch a + a {
		  margin-top: 10px;
		}
		.home-header .phone .theme-switch .logo-apple,
		.home-header .phone .theme-switch .logo-android {
		  width: 30px;
		  height: 30px;
		  margin-left: auto;
		  margin-right: auto;
		  background-size: 100% 100%;
		  background-position: center;
		  background-repeat: no-repeat;
		  margin-bottom: 3px;
		}
		.home-header .phone .theme-switch .logo-apple {
		  background-image: url(img/logo-apple.png);
		}
		.home-header .phone .theme-switch .logo-android {
		  background-image: url(img/logo-android.png);
		}
	
  </style>
  
  <!-- Emulador celular (ios e android) -->
  <div class="phone">
     <iframe src="index.html?theme=ios" frameborder="0" scrolling="no"></iframe>
  	<div class="statusbar"></div>
    <div class="theme-switch">
        <a class="active" href="index.html?theme=ios" classTheme="" target="_blank" sl-processed="1">
            <div class="theme-icon">
            <div class="logo-apple"></div><span>iOS</span>
            </div>
            <div class="fullscreen" href="kitchen-sink/core/?theme=ios"><i></i></div>
        </a>
        <a href="index.html?theme=md"  classTheme="phone-android" target="_blank" sl-processed="1" class="">
            <div class="theme-icon">
            <div class="logo-android"></div><span>MD</span>
            </div>
            <div class="fullscreen" href="kitchen-sink/core/?theme=ios"><i></i></div>
        </a>
    </div>
  </div>
  <!-- /Emulador celular -->

  	
  
</body>
</html>


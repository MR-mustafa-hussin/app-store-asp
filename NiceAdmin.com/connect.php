<?php
$sdn = "mysql:host=localhost;dbname=shop";
$user = 'root';
$pass = "";
$options = array(
PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES UTF8",
);

try {
$CON = new PDO($sdn,$user,$pass,$options);
$CON->setAttribute( PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
// echo'تم الاتصال';
}

catch(PDOException $e){
echo "falid to connect" . $e->getMessage();
}



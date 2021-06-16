<?php
class Connection{

protected function Connect(){
    
$host ="studmysql01.fhict.local";
$user = 'dbi457108';
$dbpass = 'NewPassword123';
$dbName = 'dbi457108';
$dsn = 'mysql:host='.$host.';dbname='.$dbName;

$pdo = new PDO($dsn,$user,$dbpass);
    
$pdo ->setAttribute(PDO::ATTR_DEFAULT_FETCH_MODE,
PDO::FETCH_OBJ);

return $pdo;

    
}
}
?>
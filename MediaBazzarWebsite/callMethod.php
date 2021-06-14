<?php 
include "./callMethod.php";
 $av = new AVailabliltyManager();

 $av->InsertAvailibility(5, date('DD/MM/YY'), "morning" );
?>
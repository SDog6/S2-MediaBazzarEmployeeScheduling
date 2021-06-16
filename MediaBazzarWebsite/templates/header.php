<?php 
session_start();
?>


<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Home</title>
    <link rel="stylesheet" type="text/css" href="LoginStyle.css">

<ul class="topnav">
  <li><a class="active" href="index.php">Home</a></li>
  <li><a href="#contact">Contact</a></li>
  <?php
  if(isset($_SESSION["username"])){
    echo "<li><a href='MyAccount.php' class='topnav'>" . $_SESSION["username"] ."</a></li>";
                    echo "<li><a href='scripts/logout.php' class='topnav'>Logout</a></li>";
                }
                else {
                     echo "<li><a href='login.php' class= 'topnav'> Login</a></li>";
                }
  ?>
  </ul>

</head>
<body>

    

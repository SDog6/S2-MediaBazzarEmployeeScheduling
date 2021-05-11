
<?php

include_once('./includes/autoload.inc.php');


if(isset($_POST['login_user']))
{
	
	$password = $_POST["password"];
	$username = $_POST["username"];
	$loginattempt = new Userdata();
	$founduser = $loginattempt->GetAUser($username);
	if($founduser === null ){
		header("login.php?error=wronglogin");
	}
	else if($founduser->GetUsername() == null){
		header("login.php?error=wronglogin");
	}
	else if ($password == $founduser->GetPassword()) {
		session_start();
		$_SESSION["id"] = $founduser->GetID();
		$_SESSION["username"] = $founduser->GetUsername();
		header("location: index.php");
	}  
}
?>


<!DOCTYPE html>
<?php include("./templates/header.php");?>


<div class="header">
  	<h2>Login</h2>
  </div>
	 
  <form method="post" action="login.php">
  	
  	<div class="input-group">
  		<label>Username</label>
  		<input type="text" name="username" >
  	</div>
  	<div class="input-group">
  		<label>Password</label>
  		<input type="password" name="password">
  	</div>
  	<div class="input-group">
  		<button type="submit" class="btn" name="login_user">Login</button>
  	</div>
  	<p>
  		Forgot Password? <a href="registration.php">Reset password</a>
  	</p>
  </form>

  <?php 
 if(isset($_GET["error"])){
    if($_GET["error"] == "wronglogin"){
        echo "<p>Wrong login details!</p>";
    }
}
?>
 
</body>
</html>
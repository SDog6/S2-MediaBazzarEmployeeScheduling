<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="LoginStyle.css">

<ul class="topnav">
  <li><a class="active" href="index.php">Home</a></li>
  <li><a href="MyAccount.php">My Account</a></li>
  <li><a href="#contact">Contact</a></li>
  <li><a href="login.php">Login</a></li>

</ul>


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

 
 
</body>
</html>
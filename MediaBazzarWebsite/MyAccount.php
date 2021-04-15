<!DOCTYPE html>
<?php include("./includes/autoload.inc.php");?>
<?php include("./templates/header.php");?>


<?php
$id = $_SESSION["id"];
$loginattempt = new Userdata();
$founduser = $loginattempt->GetAUserByID($id);

echo "ID: " . $founduser->GetID();
echo "<br>";
echo "Username: " . $founduser->GetUsername();
echo "<br>";
echo "Password: ********** ";
echo "<br>";
echo "<br>";
echo "<a href='changeusername.php' >Change username</a>";
echo "<br>";
echo "<a href='changeemail.php' >Change email</a>";
echo "<br>";
echo "<a href='changepassword.php' >Change password</a>";


?>
</html>
<!DOCTYPE html>

<?php include("./includes/autoload.inc.php");?>
<?php include("./templates/header.php");?>


<?php
$id = $_SESSION["id"];
$loginattempt = new Userdata();
$persondata = new PersonData();
$person = $persondata->GetPerson($id);
$founduser = $loginattempt->GetAUserByID($id);
?>

<head>
<link href="css/AccountEdit.css" rel="stylesheet">	

</head>

<body>

<form class="form-style-7" action = "AccountValidation.php" method = "POST">
<ul>
<li>
    <label for="id">ID</label>
    <input id="id" name="id" required type="text" value = "<?= $founduser->GetID(); ?>" readonly maxlength="100"/>
</li>
<li>
    <label for="url">Username</label>
    <input id="username" name="username" required type="text" value = "<?= $founduser->GetUsername(); ?>" maxlength="100">
</li>
<li>
    <label for="url">Password</label>
    <input id="password" name="password" required type="text" value = "<?= $founduser->GetPassword(); ?>" maxlength="100">
</li>
<li>
    <label for="name">Name</label>
    <input id="name" name="name" required type="text" value = "<?= $person->GetName(); ?>" readonly maxlength="100">
</li>
<li>
    <label for="email">Phone Number</label>
    <input id="phonenum" name="phonenum"  required type="text" value = "<?= $person->GetPhoneNum(); ?>" maxlength="100">
</li>
<li>
<label for="address">Address</label>
<div>
    <label for="city">City</label>
    <input id="city" name="city" required type="text" value = "<?= $person->GetCity(); ?>" maxlength="100">
</div>
<div>
    <label for="street">Street</label>
    <input id="street" name="street" required type="text" value = "<?= $person->GetStreet(); ?>"  maxlength="100">
</div>
<div>
    <label for="streetnr">Street Number</label>
    <input id="streetnr" name="streetnr" required type="text" value = "<?= $person->Getstrnum(); ?>" maxlength="100">
</div>
</li>
<li>
    <label for="email">Email</label>
    <input id="email" name="email" required type="text" value = "<?= $person->GetEmail(); ?>" maxlength="100">
</li>

<li>
    <input type="submit" value="Save Changes" onclick="myFunction()">
</li>
</ul>
</form>

</body>

<script>
function myFunction() {
  alert("Your information has been updated?");
}
</script>

</html>

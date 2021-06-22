<?php
include_once "classes/PersonData.class.php";
include_once "classes/UserData.class.php";

//if(session_id() == '') {
//	session_start();
// }
$persondata = new PersonData();
$user = new Userdata();
$id = $_POST['id'];
$newpassword = $_POST['password'];
$newemail = $_POST['email'];
$newusername = $_POST['username'];
$newphone = $_POST['phonenum'];
$account = $user->GetAUserByID($id);

$newcity = $_POST['city'];
$newstreetnr = $_POST['streetnr'];
$newstreet = $_POST['street'];

$account = $user->GetAUserByID($id);
$person = $persondata->GetPerson($id);

if($person->GetCity() != $newcity)
$persondata->UpdateCity($newcity, $id);

if($person->Getstrnum() != $newstreetnr)
$persondata->UpdateStrNr($newstreetnr, $id);

if($person->GetStreet() != $newstreet)
$persondata->UpdateStreet($newstreet, $id);

if($account->GetUsername() != $newusername)
$user->UpdateUsername($newusername, $id);

if($person->GetEmail() != $newusername)
$persondata->UpdateEmail($newemail, $id);

if($person->GetPhoneNum() != $newusername)
$persondata->UpdatePhone($newphone, $id);

if($account->GetPassword() != $newusername)
$user->UpdatePassword($newpassword, $id);

include 'MyAccount.php';

 
?>
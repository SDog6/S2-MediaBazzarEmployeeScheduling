<?php

class Person{

private $firstname;
private $lastname;
private $phonenum;
private $email;
private $city;
private $street;
private $streetnum;

private $id;

public function __construct($id, $firstname, $lastname,$phonenum, $email, $city, $street, $streetnum){
    $this->id = $id;
    $this->firstname = $firstname;
    $this->lastname = $lastname;
    $this->phonenum = $phonenum;
    $this->email = $email;
    $this->city = $city;
    $this->street = $street;
    $this->streetnum = $streetnum;

}


public function GetName(){
    return $this->firstname;
}

public function GetPhoneNum(){
    return $this->phonenum;
}

public function GetStreet(){
    return $this->street;
}

public function GetCity(){
    return $this->city;
}

public function Getstrnum(){
    return $this->streetnum;
}
public function GetEmail(){
    return $this->email;
}

public function GetLastname(){
    return $this->lastname;
}

public function SetEmail($newEmail){
    $this->email = $newEmail;
}

}


?>
<?php

class User{

private $id;
private $password;
private $username;

public function __construct($id,$password,$username){
    $this->id = $id;
    $this->password = $password;
    $this->username = $username;
}


public function GetID(){
    return $this->id;
}

public function GetPassword(){
    return $this->password;
}

public function GetUsername(){
    return $this->username;
}

/* public function GetInfo(){
    return "ID:$this->id Username:$this->username Password:$this->password Email:$this->email";
} */

}


?>
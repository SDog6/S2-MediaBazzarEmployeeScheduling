<?php
include_once ('PDO.class.php');
include_once "User.Class.php";


class Userdata extends Connection{

public function UpdateUsername($newusername,$id){
    $sql = 'UPDATE account SET username = ? WHERE id = ?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$newusername, $id]);
}

public function UpdatePassword($newpassowrd,$providedid){
    $sql = 'UPDATE account SET password = :password WHERE id = :id';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute(['password' => $newpassowrd, 'id' => $providedid]);
}

public function GetAUser($username){
    $sql = 'SELECT * FROM account WHERE username =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$username]);
    $user = $stmt->fetch();
    $fid = $user->id;
    $fusername= $user->username;
    $fpassword = $user->password;
    $founduser = new User($fid,$fpassword,$fusername);
    return $founduser;
}

public function GetAUserByID($id){
    $sql = 'SELECT * FROM account WHERE id =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$id]);
    $user = $stmt->fetch();
    $fid = $user->id;
    $fusername= $user->username;
    $fpassword = $user->password;
    $founduser = new User($fid,$fpassword,$fusername);
    return $founduser;
}

/*public function GetPersonInfo($id){
    $sql = 'SELECT person.firstName, person.lastName, person.phoneNumber,person.email, person.addressId, account.username, employee.dateOfBirth, employee.role
    FROM account LEFT JOIN employee ON account.id = employee.accountId LEFT JOIN person ON employee.personId = person.id 
    WHERE account.id =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$id]);
    $user = $stmt->fetch();
    $dfirstname = $user->firstName;
    $dlastname= $user->lastName;
    $dphonenum = $user->phoneNumber;
    $demail = $user->email;
    $daddress = $user->addressId;
    $person = new Person($dfirstname,$dlastname,$dphonenum, $demail, $daddress);
    return $person;
}
*/
}
?>
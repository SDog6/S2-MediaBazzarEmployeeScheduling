<?php
include_once ('PDO.class.php');

class Userdata extends Connection{

public function UpdateUsername($newusername,$id){
    $sql = 'UPDATE user SET username = ? WHERE id = ?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$newusername],[$id]);
    echo "nice";
}


public function UpdateEmail($newemail,$id){
    $sql = 'UPDATE user SET email = ? WHERE id = ?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$newemail],[$id]);
}


public function UpdatePassword($newpassowrd,$providedid){
    $sql = 'UPDATE user SET password = :password WHERE id = :id';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute(['password' => $newpassowrd, 'id' => $providedid]);
}

public function GetAUser($username){
    $sql = 'SELECT * FROM account WHERE username =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$username]);
    $user = $stmt->fetch();
    if($user == null){
        return null;
    }
    else {
        $fid = $user->id;
        $fusername = $user->username;
        $fpassword = $user->password;
        $founduser = new User($fid,$fpassword,$fusername);
        return $founduser;
    }
    
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

}
?>
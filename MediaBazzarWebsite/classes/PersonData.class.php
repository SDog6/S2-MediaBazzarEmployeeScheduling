<?php
include_once ('PDO.class.php');
include_once "Person.Class.php";

class PersonData extends Connection{

public function GetPerson($id){
    $sql = 'SELECT person.id, person.firstName, person.lastName, person.phoneNumber,person.email, person.addressId, account.username, employee.dateOfBirth, employee.role, address.id, address.city, address.street, address.apartmentNr
    FROM account LEFT JOIN employee ON account.id = employee.accountId LEFT JOIN person ON employee.personId = person.id LEFT JOIN address ON person.addressId = address.id
    WHERE account.id =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$id]);
    $user = $stmt->fetch();
    $pid = $user->id;
    $dfirstname = $user->firstName;
    $dlastname= $user->lastName;
    $dphonenum = $user->phoneNumber;
    $demail = $user->email;
    $dcity = $user->city;
    $dstreet = $user->street;
    $dstrnum = $user->apartmentNr;
    $person = new Person($pid, $dfirstname,$dlastname,$dphonenum, $demail, $dcity, $dstreet, $dstrnum);
    return $person;
}

public function UpdateEmail($newemail,$id){
    $sql = 'SELECT person.id, person.firstName, person.lastName, person.phoneNumber,person.email, person.addressId, account.username, employee.dateOfBirth, employee.role
    FROM account LEFT JOIN employee ON account.id = employee.accountId LEFT JOIN person ON employee.personId = person.id 
    WHERE account.id =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$id]);
    $user = $stmt->fetch();
    $pid = $user->id;

    $sql = 'UPDATE person SET email = ? WHERE id = ?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$newemail, $pid]);
}

public function UpdateStreet($newstreet,$id){
    $sql = 'SELECT person.id, person.firstName, person.lastName, person.phoneNumber,person.email, person.addressId, account.username, employee.dateOfBirth, employee.role, address.id
    FROM account LEFT JOIN employee ON account.id = employee.accountId LEFT JOIN person ON employee.personId = person.id LEFT JOIN address ON person.addressId = address.id
    WHERE account.id =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$id]);
    $user = $stmt->fetch();
    $pid = $user->addressId;

    $sql = 'UPDATE address SET street = ? WHERE id = ?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$newstreet, $pid]);
}

public function UpdateCity($newcity,$id){
    $sql = 'SELECT person.id, person.firstName, person.lastName, person.phoneNumber,person.email, person.addressId, account.username, employee.dateOfBirth, employee.role, address.id
    FROM account LEFT JOIN employee ON account.id = employee.accountId LEFT JOIN person ON employee.personId = person.id LEFT JOIN address ON person.addressId = address.id
    WHERE account.id =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$id]);
    $user = $stmt->fetch();
    $pid = $user->addressId;

    $sql = 'UPDATE address SET city = ? WHERE id = ?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$newcity, $pid]);
}

public function UpdateStrNr($newNr,$id){
    $sql = 'SELECT person.id, person.firstName, person.lastName, person.phoneNumber,person.email, person.addressId, account.username, employee.dateOfBirth, employee.role, address.id
    FROM account LEFT JOIN employee ON account.id = employee.accountId LEFT JOIN person ON employee.personId = person.id LEFT JOIN address ON person.addressId = address.id
    WHERE account.id =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$id]);
    $user = $stmt->fetch();
    $pid = $user->addressId;

    $sql = 'UPDATE address SET apartmentNr = ? WHERE id = ?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$newNr, $pid]);
}

public function UpdatePhone($newphone,$id){
    $sql = 'SELECT person.id, person.firstName, person.lastName, person.phoneNumber,person.email, person.addressId, account.username, employee.dateOfBirth, employee.role
    FROM account LEFT JOIN employee ON account.id = employee.accountId LEFT JOIN person ON employee.personId = person.id 
    WHERE account.id =?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$id]);
    $user = $stmt->fetch();
    $pid = $user->id;

    $sql = 'UPDATE person SET phoneNumber = ? WHERE id = ?';
    $stmt = $this->Connect()->prepare($sql);
    $stmt->execute([$newphone, $pid]);
}

}
?>
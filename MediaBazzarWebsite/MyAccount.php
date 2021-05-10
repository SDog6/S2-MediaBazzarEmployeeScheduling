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

$host ="studmysql01.fhict.local";
$user = 'dbi457108';
$dbpass = 'NewPassword123';
$dbName = 'dbi457108';
$dsn = 'mysql:host='.$host.';dbname='.$dbName;

try
{
$pdo = new PDO($dsn,$user,$dbpass);
$sql = "SELECT person.firstName, person.lastName, person.phoneNumber,person.email, person.addressId, account.username, employee.dateOfBirth, employee.role
 FROM account LEFT JOIN employee ON account.id = employee.accountId LEFT JOIN person ON employee.personId = person.id 
 WHERE account.id LIKE :accountId";
$stm = $pdo->prepare($sql);
$stm->bindParam(":accountId", $id);
$stm->execute();

  
$result = $stm->setFetchMode(PDO::FETCH_ASSOC);

foreach($stm->fetchAll() as $k=>$v) {
    echo "<br><br><br><br>";
    echo "firstname: " . $v['firstName']; 
    echo "<br>";
    echo "lastname: " . $v['lastName'];
    echo "<br>";
    echo "PhoneNumber:" . $v['phoneNumber'];
    echo "<br>";
    echo "Email adress: " . $v['email'];
    echo "<br>";
    echo "Adress: " . $v['addressId'];
    echo "<br>";
    echo "Username: " . $v['username'];
    echo "<br>";
    echo "Date of Birth: " . $v['dateOfBirth'];
    echo "<br>";
    echo "Role : " . $v['role'];

}
     $pdo = null;
    }
     catch(PDOException $e)
     {
         echo $e->getMessage();
     }
     $conn = null;
 


?>
</html>
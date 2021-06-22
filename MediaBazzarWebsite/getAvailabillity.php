<?php   
include_once("./classes/Userdata.class.php");

class GetData 
{
 
 private   $host = "studmysql01.fhict.local";  
 private   $username = "dbi457108";  
 private   $password = "NewPassword123";  
 private   $dbname = "dbi457108"; 
    
 public function GetAvailabillity()
 {

     try
     {
         $pdo = new PDO("mysql:host=$this->host;dbname=$this->dbname",$this->username, $this->password);  
         $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
         
         $emp = new Userdata();
         $eid = $emp->GetEmpByID($_SESSION['id']);
         $member = $eid;  
         $id = $eid;
         $stmt = $pdo->prepare("SELECT Date, Type FROM `shiftsrequests` where employee_id=:id"  );
         $stmt->bindParam(":id", $id);
         $stmt->execute();
         $result = $stmt->setFetchMode(PDO::FETCH_ASSOC);
         foreach($stmt->fetchAll() as $k=>$v) {
            echo $v['Date'] . " - " . $v['Type'] . "<br>";
             
            }
            
        }
        
        catch(PDOException $e)
        {
            echo $e->getMessage();
        }
        
        $pdo = null;
        
    }
}



?>
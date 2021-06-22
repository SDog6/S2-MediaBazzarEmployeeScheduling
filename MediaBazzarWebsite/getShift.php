<?php 

class shift
{
    private   $host = "studmysql01.fhict.local";  
    private   $username = "dbi457108";  
    private   $password = "NewPassword123";  
    private   $dbname = "dbi457108"; 

    function GetShift($date, $id)
    {
       try
       {
        $pdo = new PDO("mysql:host=$this->host;dbname=$this->dbname",$this->username, $this->password);  
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);       
        $stmt = $pdo->prepare("SELECT a.id , s.Date, s.Type , e.personId, a.username FROM shifts as s INNER JOIN employee as e ON s.employee_id = e.id INNER JOIN account as a on a.id = e.accountId WHERE a.id LIKE :id and s.Date = :Date"  );
        $stmt->bindParam(":id", $id);
        $stmt->bindParam(":Date", $date);
        $stmt->execute();
        if($stmt->fetchAll() == null)
        {
            echo "No shift planned";
        }
        $stmt->execute();
        foreach($stmt->fetchAll() as $k=>$v) {
            echo $v['Date'] . " - " . $v['Type'] . "<br>";
             
            }
    }
       catch(PDOException $e)
       {
          echo $e->getMessage();
       }
    }



}






?>
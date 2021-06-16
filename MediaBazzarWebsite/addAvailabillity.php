<?php   
session_start();

    
     $host = "studmysql01.fhict.local";  
     $username = "dbi457108";  
      $password = "NewPassword123";  
     $dbname = "dbi457108"; 
    
   
        
        try
        {

            
            $pdo = new PDO("mysql:host=$host;dbname=$dbname",$username, $password);  
            $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            
            $member = $_SESSION['id'];  
            $available = true;
            $date = date('d/m/y');
            $shift = $_POST['Shift'];
            $date = $_POST['Day'];

            $handle = $pdo->prepare("SELECT * FROM shiftsrequests where employee_id =:member and Type=:shift and Date=:date");
            $handle->bindParam(':member', $member);
            $handle->bindParam(':date', $date );
            $handle->bindParam(':shift', $shift);
            $handle->execute();
            if($handle->rowCount() == 0)
            {

                $stmt = $pdo->prepare("INSERT INTO shiftsrequests (employee_id, Date, type)  VALUES (:member, :date, :shift)");
                $stmt->bindParam(':member', $member);
                $stmt->bindParam(':date', $date );
                $stmt->bindParam(':shift', $shift);
                
                $stmt->execute();
            }
            elseif($handle->rowCount() > 0)
            {
               $statement = $pdo->prepare("DELETE FROM shiftsrequests WHERE employee_id=:member and Type=:shift and date=:date ");
               $statement->bindParam(':member', $member);
               $statement->bindParam(':date', $date );
               $statement->bindParam(':shift', $shift);
               $statement->execute();

            }
            
            
            
            
        }
        catch(PDOException $e)
        {
            echo "PDO error".$e->getMessage();
            die();
        }
        finally
        {
           // header('location:./index.php');
            
        }
    
    





?>



    
</body>
</html>
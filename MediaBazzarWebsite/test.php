<?php   
session_start();
class AVailabliltyManager
{
    
    private  $host = "localhost";  
    private $username = "root";  
    private  $password = "";  
    private $dbname = "mediabazar"; 
    
    function InsertAvailibility($member, $date, $shift)
    {
        
        try
        {
            $pdo = new PDO("mysql:host=$this->host;dbname=$this->dbname",$this->username, $this->password);  
            $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
            
            
            $available = true;
            $stmt = $pdo->prepare("INSERT INTO availability (member, date, shift, available)  VALUES (:member, :date, :shift, :available)");
            $stmt->bindParam(':member', $member);
            $stmt->bindParam(':date', $date );
            $stmt->bindParam(':shift', $shift);
            $stmt->bindParam(':available', $available);
            $stmt->execute();
            
            
            
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
    }
    
}
$av = new AVailabliltyManager();
$date = "<script>document.write(date)</script>";
$shift = $_POST['selectedTime'];
echo $date;
echo  "<script>document.write(data)</script>";

$member = $_SESSION['id'];
$av->InsertAvailibility($member, $date, $shift);
?>
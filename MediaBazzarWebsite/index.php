<?php 

 include("./templates/header.php");?>
<?php include("./scripts/protectedpage.php");?>

<!doctype html>
<html>
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Availability</title>
    <link href="https://www.jqueryscript.net/css/jquerysctipttop.css" rel="stylesheet" type="text/css">
    <link rel="stylesheet" type="text/css" href="css/mark-your-calendar.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css">
    <style>
      body { background-color: #fafafa; }
      .container { margin: 150px auto; }
    </style>
</head>
<h1 style="text-align: center;"> Availability </h1>





<!DOCTYPE html>
<html>
<head>
  <style>

    table {
      width:70%;
      margin: auto;
      position: center;
    }
    table, th, td {
      border: 1px solid black;
      border-collapse: collapse;
    }
    th, td {
      padding: 15px;
      text-align: left;
    }
    #t01 tr:nth-child(even) {
      background-color: #eee;
    }
    #t01 tr:nth-child(odd) {
     background-color: #fff;
    }
    #t01 th {
      background-color: black;
      color: white;
    }
    #shif th {
      background-color: black;
      color: white;
    }
    </style>
    </head>
    <body>
    
 
  
   
    
    <table id="t01">
      <tr>
      
        <th>Monday</th>
        <th>Tuesday</th> 
        <th>Wednesday</th>
        <th>Thursday</th>
        <th>Friday</th>
        <th>Saturday</th>
        <th>Sunday</th>
      </tr>
      <tr>
        
        <td><button id="MorningShift Monday" value="MorningShift Monday">Morning Shift</button></td>
        <td><button value="MorningShift Tuesday">Morning Shift</button></td>
        <td><button value="MorningShift Wednesday">Morning Shift</button></td>
        <td><button value="MorningShift Thursday">Morning Shift</button></td>
        <td><button value="MorningShift Friday">Morning Shift</button></td>
        <td><button value="MorningShift Saturday">Morning Shift</button></td>
        <td><button value="MorningShift Sunday">Morning Shift</button></td>
      </tr>
      <tr>
        
        <td><button value="EveningShift Monday" >Evening Shift</button></td>
         <td><button value="EveningShift Tuesday" >Evening Shift</button></td>
         <td><button value="EveningShift Wednesday">Evening Shift</button></td>
         <td><button value="EveningShift Thursday">Evening Shift</button></td>
         <td><button value="EveningShift Friday">Evening Shift</button></td>
         <td><button value="EveningShift Saturday">Evening Shift</button></td>
         <td><button value="EveningShift Sunday">Evening Shift</button></td>
    
      </tr>
      <tr>
         <td><button value="NightShift Monday">Night Shift</button></td>
         <td><button value="NightShift Tuesday">Night Shift</button></td>
         <td><button value="NightShift Wednesday">Night Shift</button></td>
         <td><button value="NightShift Thursday">Night Shift</button></td>
         <td><button value="NightShift Friday">Night Shift</button></td>
         <td><button value="NightShift Saturday">Night Shift</button></td>
         <td><button value="NightShift Sunday">Night Shift</button></td>
       
      
      </tr>
    </table>
    <h5 style="margin-left: 9cm ">Choosen hours:</h5>
<?php 
include"./getAvailabillity.php";
$av = new GetData;
?>
<html>
  <p style=" margin-left: 10cm">
</html>
<?php
$av->GetAvailabillity();

?>
<html>
  <p>
</html>
<br>
<?php 
$monday = date( 'Y-m-d', strtotime( 'monday this week' ) );
$tuesday = date( 'Y-m-d', strtotime( 'tuesday this week' ) );
$wednesday = date( 'Y-m-d', strtotime( 'wednesday this week' ) );
$thursday = date( 'Y-m-d', strtotime( 'thursday this week' ) );
$friday = date( 'Y-m-d', strtotime( 'friday this week' ) );
$saturday = date( 'Y-m-d', strtotime( 'saturday this week' ) );
$sunday = date( 'Y-m-d', strtotime( 'sunday this week' ) );

include "./getShift.php";
?>
<h1>Shift Schedule<h1>
<?php 
echo "<br>";
echo "<h5> This week </h5>"

?>

<table id="shift" style="width: 95%;">

<tr>
        <th>Monday <?php echo $monday?></th>
        <th>Tuesday <?php echo $tuesday?></th> 
        <th>Wednesday <?php echo $wednesday?></th>
        <th>Thursday <?php echo $thursday?></th>
        <th>Friday <?php  echo $friday?></th>
        <th>Saturday <?php echo $saturday?></th>
        <th>Sunday <?php echo $sunday?></th>
      </tr>
      <tr>
      
      <td><?php $shift = new shift; $shift->GetShift($monday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($tuesday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($wednesday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($thursday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($friday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($saturday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($sunday, $_SESSION['id'])?></td>
      </tr>
      
 
</table>
    

    
<?php 

echo "<br>";
echo "<h5> Next week </h5>";


$monday = date( 'Y-m-d', strtotime( 'monday next week' ) );
$tuesday = date( 'Y-m-d', strtotime( 'tuesday next week' ) );
$wednesday = date( 'Y-m-d', strtotime( 'wednesday next week' ) );
$thursday = date( 'Y-m-d', strtotime( 'thursday next week' ) );
$friday = date( 'Y-m-d', strtotime( 'friday next week' ) );
$saturday = date( 'Y-m-d', strtotime( 'saturday next week' ) );
$sunday = date( 'Y-m-d', strtotime( 'sunday next week' ) );

echo "<br>";
?>


<table id="shift" style="width: 95%;">

<tr>
        <th>Monday <?php echo $monday?></th>
        <th>Tuesday <?php echo $tuesday?></th> 
        <th>Wednesday <?php echo $wednesday?></th>
        <th>Thursday <?php echo $thursday?></th>
        <th>Friday <?php  echo $friday?></th>
        <th>Saturday <?php echo $saturday?></th>
        <th>Sunday <?php echo $sunday?></th>
      </tr>
      <tr>
      
      <td><?php $shift = new shift; $shift->GetShift($monday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($tuesday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($wednesday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($thursday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($friday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($saturday, $_SESSION['id'])?></td>
      <td><?php $shift = new shift; $shift->GetShift($sunday, $_SESSION['id'])?></td>
      <tr>
</table>
<?php echo "<br>";?>
<?php echo "<br>";?>
<?php echo "<br>";?>
<?php echo "<br>";?>
  </body>

</html>

</body>
</html>
<script>
function LoadData()
{
  $.ajax({



  })
}
</script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>  



<script>
//Get the value of the clicked button and split the shift and day
$("button").click(function() {
    var fired_button = $(this).val();
    var Shift = fired_button.split(" ")[0];
    var Day = fired_button.split(" ")[1];
    alert(fired_button);
// send value to php using Ajax
    $.ajax({
      url: "./addAvailabillity.php",
      method: "POST",
      data: {Shift: Shift , Day : Day},
      success:function(data){
        $('#result').html(data);
      }
    })
 
});
</script>

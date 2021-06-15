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
<h1 style="text-align: center;"> Avaliabillity </h1>





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
        
        <td><button value="MorningShift Monday">Morning Shift</button></td>
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
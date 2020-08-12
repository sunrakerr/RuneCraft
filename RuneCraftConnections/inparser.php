<?php
    
    $con = mysqli_connect('localhost','root','','runecraftdb');
    $con2 = mysqli_connect('localhost','root','','runecraftdb');

    $takeName = "SELECT curr_name FROM currentuser";
    $checkIfName = mysqli_query($con,$takeName) or die("1: failed to parse from currentuser");

    if(mysqli_num_rows($checkIfName)>0)
    {
       $infoParse = mysqli_fetch_assoc($checkIfName);
       $matchUserIg = "SELECT igName,coins,curr_damage,curr_speed FROM useringame WHERE igName ='" .$infoParse['curr_name']. "';";
       $checkIfNameTwo = mysqli_query($con, $matchUserIg)or die("2: failed to parse from igtable");
        
       if(mysqli_num_rows($checkIfNameTwo)>0)
       {
        $infoParseTwo = mysqli_fetch_assoc($checkIfNameTwo); 
        echo "" .$infoParseTwo["igName"]. "\t" .$infoParseTwo["coins"] . "\t" . $infoParseTwo["curr_damage"]. "\t" .$infoParseTwo["curr_speed"] ;
       }
    }

    
    
?>

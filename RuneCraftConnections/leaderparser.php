<?php
         $con = mysqli_connect('localhost','root','','runecraftdb');
  
     
         $takeName = "SELECT name,score FROM leaderboard";
         $checkIfName = mysqli_query($con,$takeName) or die("1: failed to parse from currentuser");
     
         if(mysqli_num_rows($checkIfName)>0)
         {
             for(int i=0;i<mysqli_num_rows($checkIfName);i++)
             {
            $infoParseTwo = mysqli_fetch_assoc($checkIfName);
            echo "" .$infoParseTwo["name"]. "|" .$infoParseTwo["score"] . "\n"  ;
             }
  
         }
     
?>
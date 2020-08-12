<?php

    $con = mysqli_connect('localhost','root','','runecraftdb');

    //testing for con
    if(mysqli_connect_errno())
    {
        echo "1: Connection failed";//error code 1 means connection failed
        exit();
    }

    $coin = $_POST["coins"];
    $score = $_POST["score"];
    $kills = $_POST["kills"];
    $damage = $_POST["damage"];
    $speed = $_POST["speed"];
    $name = $_POST["name"];

    $checkScoreQuery = "SELECT highScore FROM useringame WHERE igName ='" . $name . "' AND highScore > '" .$score. "';";
    $checkNameQuery = "SELECT igName FROM useringame WHERE igName='" . $name . "';";
    
    $checkName = mysqli_query($con, $checkNameQuery) or die("2"); // name check failed
    $checkScore = mysqli_query($con,$checkScoreQuery) or die("2");
    
    $updateUser = "UPDATE useringame SET coins = '" . $coin . "', highScore = '" .$score. "', killCount = killCount+'" .$kills. "', curr_damage = '" .$damage. "', curr_speed = '" .$speed. "' WHERE igName = '" .$name. "';";  
    $updateUser2 = "UPDATE useringame SET coins = '" . $coin . "', killCount = killCount+'" .$kills. "', curr_damage = '" .$damage. "', curr_speed = '" .$speed. "' WHERE igName = '" .$name. "';";  
    $insertNew = "INSERT INTO useringame (coins,highScore,killCount,curr_damage) VALUES ('" . $coin . "','" . $score . "','" . $kills. "','" . $damage. "');";
    
    
    $updateLeader = "UPDATE leaderboard SET score = '" . $score. "' WHERE name = '" .$name. "';";

    if(mysqli_num_rows($checkName)>0)
    {
        if(mysqli_num_rows($checkScore)>0) //if current score is not greater than existing score
        {
            mysqli_query($con, $updateUser2) or die("3: Failed to update");
            
       
        }
        else{
            mysqli_query($con, $updateUser) or die("3: Failed to update");
            mysqli_query($con, $updateLeader) or die("3: Failed to update");
        }
        
    }
    else{
        mysqli_query($con, $insertNew) or die("2: Failed to add");

    }

    echo("0");

?>
<?php
		// Explore system variables on host machine, so DB login isn't stored in plaintext php file
		// Uses SetEnv in .htaccess, need to find out where that goes. Inside an IfModule ...?
		
		// replaced w/ placeholders to protect host login details for github commit
    $hostname = 'placeholder';
    $username = 'placeholder';
    $password = 'placeholder';
    $database = 'placeholder';
    
    // Exits script when connection unable to be established.
    if (!$con = mysqli_connect($hostname, $username, $password, $database)) {
    				echo("-2"); // for failed DB connection
            exit(); // Hopefully this doesn't clear the echo above...
    }
		
		// Making escapes for any special characters in user input.
		$deskID = mysql_real_escape_string($_POST["deskID"], $con); // should have format 'DESK-XX(-YY)' where (-YY) is optional
    $staffID = mysql_real_escape_string($_POST["staffID"], $con); // should have format 'STAFF-XX'
    $date = mysql_real_escape_string($_POST["date"], $con); // should have format 'YYYY-MM-DD'
    $start = mysql_real_escape_string($_POST["startTime"], $con); // should have format 'HH:MM:SS', can append ':SS' in c# script
    $end = mysql_real_escape_string($_POST["endTime"], $con); // format as above
    
		// Preparing booking insert
		$pst = $con->prepare("INSERT INTO `BOOKING` (deskID, staffBooked, bookingDate, startTime, endTime) VALUES (?,?,?,?,?)");
		$pst->bind_param("sssss", $username, $password);
		$booked = $pst->execute();
		
		if(!$booked) {
            echo("-1");
            exit(); // Hopefully this doesn't clear the echo above...
    }
?> 
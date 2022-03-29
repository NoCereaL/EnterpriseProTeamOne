<?php
		// Explore system variables on host machine, so DB login isn't stored in plaintext php file
		// Uses SetEnv in .htaccess, need to find out where that goes. Inside an IfModule ...?
		
		// Replaced with placeholders to protect host information for github publishing.
    $hostname = 'Placeholder'; 
    $username = 'Placeholder';
    $password = 'Placeholder';
    $database = 'Placeholder';
    
    // Exits script when connection unable to be established.
    if (!$con = mysqli_connect($hostname, $username, $password, $database)) {
    				echo("-2"); // for failed DB connection
            exit(); // Hopefully this doesn't clear the echo above...
    }
		
		// Making escapes for any special characters in user input.
		$username = mysql_real_escape_string($_POST["user"], $con);
    $password = mysql_real_escape_string(md5($_POST["pass"]), $con); // md5 encryption, may change to sha256
    
		// Checking STAFF table for matching login.
		$pst = $con->prepare("SELECT * FROM `STAFF` WHERE BINARY staffID = ? AND BINARY password = ?");
		$pst->bind_param("ss", $username, $password); 
		$result = $pst->get_result();
		
		if(mysqli_num_rows($result) > 0) {
            echo("Approved");
            exit(); // Hopefully this doesn't clear the echo above...
    }
		
		// Checking MANAGER table for matching login.
		$pst = $con->prepare("SELECT * FROM `MANAGER` WHERE BINARY managerID = ? AND BINARY password = ?");
		$pst->bind_param("ss", $username, $password);
		$result = $pst->get_result();
		
		if(mysqli_num_rows($result) > 0) {
            echo("1");
            exit();
    }
		
		// Checking ADMINISTRATOR taable for matching login.
		$pst = $con->prepare("SELECT * FROM `ADMINISTRATOR` WHERE BINARY administratorID = ? AND BINARY password = ?");
		$pst->bind_param("ss", $username, $password);
    $result = $pst->get_result();

    if(mysqli_num_rows($result) > 0) {
            echo("0");
            exit();
    }
    
    // Default output for failed login.
    echo("-1");
    exit();
?> 
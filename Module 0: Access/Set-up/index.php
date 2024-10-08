<!DOCTYPE HTML>
<HTML>
<head>
	<meta charset="utf-8" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" type="text/css" href="css/style.css" />
	<title>Set-up by Adminique</title>
	<script>
		function ConfirmSetup()
		{
			let x = document.forms["SetupAccount"]["AccessToken"].value;
			let y = x.charAt(3);
			if (y != "")
			{
				if (y == "X" || y == "Y" || y == "Z")
				{
				return true;
				}
				else
				{
					alert("Access token invalid.")
					return false;
				}
			}
			else
			{
				alert("Enter access token.");
				return false;
			}
		}
	</script>
</head>

<body>
	<div class="title"> 
			<h1>Link the Access Token</h1>
	</div>
	<div class="container">
		<form name="setupaccount" action="confirm.php" onsubmit="return ConfirmSetup()" method="POST">
			Access Token: <input type="text" name="AccessToken" required><br/>
			First Name: <input type="text" name="FirstName" required><br/>
			Last Name: <input type="text" name="LastName" required><br/>
			E-Mail: <input type="email" name="EMail" required><br/>
			<input type="submit" value="Submit">
		</form>
	</div>
	<div class="copy">
			<p>&copy; Adminique - All Rights Reserved</p>
	</div>
</body>

</HTML>

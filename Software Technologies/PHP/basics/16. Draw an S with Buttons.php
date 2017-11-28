<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
for($y = 1; $y <= 9; $y++){
    for($x = 1; $x <=5; $x++){
            
            if($y == 1 || $y == 5 || $y == 9){echo"<button style='background-color:blue'>1</button>";}
            else
            if($y < 5 && $y > 1 &&$x == 1){echo"<button style='background-color:blue'>1</button>";}
            else
            if($y > 5 && $y < 9 &&$x == 5){echo"<button style='background-color:blue'>1</button>";}
            else
            {echo"<button>0</button>";}
     }
     echo "<br>";
    }
    ?>
</body>
</html>

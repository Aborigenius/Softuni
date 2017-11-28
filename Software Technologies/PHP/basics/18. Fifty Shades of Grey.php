<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style> 
</head>
<body>
<?php
$color = 0;
$color5 = $color + 5;
$color10 = $color + 10;
for($y = 1; $y <= 5; $y++){
    for($x = 1; $x <=10; $x++){
        if($y == 1)
        echo "<div style='background-color:rgb($color, $color5, $color10)'></div>";
        if($y == 2)
        echo "<div style='background-color:rgb($color, $color5, $color10)'></div>";
        if($y == 3)
        echo "<div style='background-color:rgb($color, $color5, $color10)'></div>";
        if($y == 4)
        echo "<div style='background-color:rgb($color, $color5, $color10)'></div>";
        if($y == 5)
        echo "<div style='background-color:rgb($color, $color5, $color10)'></div>";
     }
     echo "<br>";
     $color += 51;
     $color5 += 51;
     $color10 += 51;
    }
    ?>
</body>
</html>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php 
 if(isset($_GET['num'])){
    $num = intval($_GET['num']);
    $prev = 1;
    $next = 1;
    $third = 2;
    echo "$prev $next $third ";
    for($i = 3; $i < $num; $i++){
    $trib = $prev + $next + $third;
    $prev = $next;
    $next = $third;
    $third = $trib;
    echo "$trib ";}
    }
     ?>
</body>
</html>
<?php
function getUserByCityId($id){
$dotenv = new Symfony\Component\Dotenv\Dotenv();
$dotenv->load(__DIR__.'/my.env');
$host = getenv('MYSQL_HOST');
$user = getenv('MYSQL_USER');
$pswd = getenv('MYSQL_PASSWORD');
$db = getenv('DATABASE_NAME');
$conn = new mysqli($host, $user, $pswd, $db);
if($conn->connect_error){
    die("Что-то пошло не так");
}
echo "Соединение с БД установлено";
$sql = "SELECT * FROM Users WHERE City_id = '$id'";
if($result = $conn->query($sql)){ 
	$rowsCount = $result->num_rows;
	if ($rowsCount !=0){
    	echo "<table><tr><th>ID</th><th>Имя</th><th>Почта</th><th>Телефон</th>";
    	foreach($result as $row){
        echo "<tr>";
            echo "<td>" . $row["id"] . "</td>";
            echo "<td>" . $row["Name"] . "</td>";
            echo "<td>" . $row["Email"] . "</td>";
            echo "<td>" . $row["Phone"] . "</td>";
        echo "</tr>";    
    }
        echo "</table>";
    }
	else {
	echo "<h4>";
    echo "Пользователей из такого города нет " ;
   $result->free();
} 
}
}
getUserByCityId(1);
?>

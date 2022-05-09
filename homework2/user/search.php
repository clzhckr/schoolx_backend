<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");

include_once '../config/database.php';
include_once '../models/user.php';

$database = new Database();
$db = $database->getConnection();

$user = new User($db);

$keywords=isset($_GET["s"]) ? $_GET["s"] : "";

$stmt = $user->search($keywords);
$num = $stmt->rowCount();

if ($num>0) {

    $users_arr=array();
    $users_arr["records"]=array();

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)){

        $user_arr["records"][] = $row;
    }

    http_response_code(200);

    echo json_encode($users_arr);
}

else {
    http_response_code(404);

    echo json_encode(array("message" => "Записи не найдены."), JSON_UNESCAPED_UNICODE);
}
?>